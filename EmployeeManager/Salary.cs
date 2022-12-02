using EmployeeManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    //this is the salary page, here we can calculate employee salary.
    public partial class Salary : Form
    {
        int isAdmin;
        string name;
        bool pressed = false, calculated = false;
        public Salary(int x, string n)
        {
            InitializeComponent();
            isAdmin = x;
            name = n;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30");
        int Dailybase;
        private string TableName = "EmployeesTbl";
        private void pictureBox2_Click(object sender, EventArgs e)//click on home
        {
            Home home = new Home(isAdmin, name);
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)//click on 'X'
        {
            Application.Exit();
        }

        //this function using the id given by the user to get from the DB the name and position of the employee. 
        private void fetchData()
        {
            connection.Open();
            string query = "select * from " + TableName + " where Id='" + EmpIDS.Text + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            EmpNameS.Text = dt.Rows[0]["Name"].ToString();
            EmpPositionS.Text = dt.Rows[0]["Position"].ToString();
            connection.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)//click on calculate
        {
            if(EmpPositionS.Text == "" || EmpNameS.Text == "") //if one or more textbox is empty of text
            { 
                MessageBox.Show("Please select an employee"); 
            }
            else if(WorkedD.Text == "" || !IsNumeric(WorkedD.Text))//if the worked days value is not valid
            {
                MessageBox.Show("Please enter vaalid nuber of worked days"); 
            }
            else
            {//calculate salary and display
                Dailybase = SetDaylyBase();
                int total = Dailybase * Convert.ToInt32(WorkedD.Text);
                SetSalaryText(Dailybase, total);
                calculated = true;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)//click on fetch data
        {
            if (EmpIDS.Text == "")//if id textbox is empty of text
            {
                MessageBox.Show("Please enter the employee ID");
            }
            else
            {
                fetchData();
                pressed = true;
            }
        }

        public static bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
        public int SetDaylyBase()//positions salary table 
        {
            switch (EmpPositionS.Text)
            {
                case "Manager":
                    return 1500;
                case "Senior Developer":
                    return 1000;
                case "Junior Developer":
                    return 700;
                case "HR":
                    return 620;
                case "Accountant":
                    return 650;
                case "Receptionist":
                    return 300;
                default:
                    return 30;
            }
        }

        public void SetSalaryText(int daily, int total)//display salary calculation
        {
            SalaryBox.Text =
                "Employee ID: " + EmpIDS.Text + "\n" +
                "Employee name:" + EmpNameS.Text + "\n" +
                "Employee position: " + EmpPositionS.Text + "\n" +
                "Worked days: " + WorkedD.Text + "\n" +
                "Daily salary: ₪" + daily + "\n" +
                "Total salary for " + WorkedD.Text + " days: ₪" + total;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)//press on print
        {
            if (pressed && calculated)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else if(pressed)//if the user pressed on fetch data but did not do a salary calculation
            {
                MessageBox.Show("Please make a calculation");
            }
            else//if the user didn't even pressed on fetch data
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)//create the print document
        {
            Bitmap bitmap = new Bitmap(Resources.logo1);
            Bitmap resized = new Bitmap(bitmap, new Size(bitmap.Width / 2, bitmap.Height / 2));
            e.Graphics.DrawImage(resized, new Point(0));
            e.Graphics.DrawString("Salary Summary", new Font("Century Gothic", 20, FontStyle.Underline), Brushes.Black, new Point(230, 100));
            e.Graphics.DrawString("Employee id: " + SalaryBox.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(15, 160));
        }
    }
}
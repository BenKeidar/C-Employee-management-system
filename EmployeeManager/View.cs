using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EmployeeManager.Properties;

namespace EmployeeManager
{
    public partial class View : Form
    {
        //in this page the user can insert an employee id and get all of his details.
        private string TableName = "EmployeesTbl";
        int isAdmin;
        string name;
        bool pressed = false;
        public View(int x, string n)
        {
            InitializeComponent();
            isAdmin = x;
            name = n;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30");

        //this function using the id given by the user to get from the DB the details of the employee and display them.
        private void fetchData()
        {
            connection.Open();
            string query = "select * from " + TableName + " where Id='" + EmpIDBox.Text + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            EmpIDL.Text = dt.Rows[0]["Id"].ToString();
            EmpNameL.Text = dt.Rows[0]["Name"].ToString();
            EmpAddressL.Text = dt.Rows[0]["Address"].ToString();
            EmpDOBL.Text = dt.Rows[0]["DOB"].ToString();
            EmpPhoneL.Text = dt.Rows[0]["Phone"].ToString();
            EmpPositionL.Text = dt.Rows[0]["Position"].ToString();
            EmpEducationL.Text = dt.Rows[0]["Education"].ToString();
            EmpGenderL.Text = dt.Rows[0]["Gender"].ToString();
            connection.Close();
        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)//click on view
        {
            if (EmpIDBox.Text == "") {//if id textbox is empty
                MessageBox.Show("Please enter the employee ID");
            }
            else
            {
                fetchData();
                pressed = true;
            }      
        }

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

        private void bunifuThinButton23_Click(object sender, EventArgs e)//click on print
        {
            if (pressed)//if the user already pressed on view to get details of an employee
            {
                if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//create the print document
        {
            Bitmap bitmap = new Bitmap(Resources.logo1);
            Bitmap resized = new Bitmap(bitmap, new Size(bitmap.Width / 2, bitmap.Height / 2));
            e.Graphics.DrawImage(resized, new Point(0));
            e.Graphics.DrawString("Employee Summary", new Font("Century Gothic",20,FontStyle.Underline),Brushes.Black, new Point(230,100));
            e.Graphics.DrawString("Employee id: " + EmpIDL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,160));
            e.Graphics.DrawString("Employee name: " + EmpNameL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,200));
            e.Graphics.DrawString("Employee address: " + EmpAddressL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,240));
            e.Graphics.DrawString("Employee phone: " + EmpPhoneL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,280));
            e.Graphics.DrawString("Employee position: " + EmpPositionL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,320));
            e.Graphics.DrawString("Employee education: " + EmpEducationL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,360));
            e.Graphics.DrawString("Employee gender: " + EmpGenderL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,400));
            e.Graphics.DrawString("Employee date of birth: " +EmpDOBL.Text, new Font("Century Gothic",18,FontStyle.Regular),Brushes.Black, new Point(15,440));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

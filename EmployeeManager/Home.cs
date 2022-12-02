using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManager.Properties;

namespace EmployeeManager
{
    //This is the home page.
    public partial class Home : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30"); 
        private string TableName = "Users";
        private int isAdmin;
        private string name;
        public Home(int x, string uname)
        {
            InitializeComponent(); 
            if(x == 0)//if the user is not an admin, the addUser button will not apear
            {
                addUserBTN.Visible = false;
            }
            isAdmin = x;
            name = uname;
            helloLable.Text = "Hello " + name;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)//click on employee
        {
            Employee employee = new Employee(isAdmin, name);
            employee.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)//click on logout
        {
            UpdateConnection();
            Login login = new Login();  
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//click on view
        {
            View view = new View(isAdmin, name);
            view.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//click on salary
        {
            Salary salary = new Salary(isAdmin, name);
            salary.Show();
            this.Hide();
        }

        private void addUserBTN_Click(object sender, EventArgs e)//click on adduser
        {
            AddUser addUser = new AddUser(connection, TableName, isAdmin, name);
            addUser.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)//click on 'X;
        {
            Application.Exit();
        }
        //this function updates the DB that the user disconnected
        private void UpdateConnection()
        {
            connection.Open();
            string query = "update " + TableName + " set Connected='0' where Username='" + this.name + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}

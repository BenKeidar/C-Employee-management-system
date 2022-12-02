using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    //in this page the user can add a new user (with or without admin permission) and delete a user.
    public partial class AddUser : Form
    {
        private SqlConnection connection;
        private string TableName;
        int isAdmin;
        string name;
        public AddUser(SqlConnection con, string tableName, int x, string n)
        {
            InitializeComponent();
            this.connection = con;
            this.TableName = tableName;
            isAdmin = x;
            name = n;
        }

        private void pictureBox2_Click(object sender, EventArgs e)//click on home.
        {
            Home home = new Home(isAdmin, name);
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//click on add user
        {
            if (Uname.Text == "" || UPass.Text == "")//if one or more textbox is empty of text
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                try
                {
                    int isNewUserAdmin = 0;
                    if (checkBox1.Checked == true) { isNewUserAdmin = 1; }
                    connection.Open();
                    if (!UserExist())//if ther is no other user with the same name
                    {
                        string query = buildInsertQuery(isNewUserAdmin);
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New User seccessfully added!");
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Username already exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//click on clear
        {
            Uname.Text = "";
            UPass.Text = "";
        }
        private string buildInsertQuery(int isNewUserAdmin)//builds query to add new user
        {
            string query = "insert into " + TableName + " values('"
                + Uname.Text + "','"
                + UPass.Text + "',"
                + isNewUserAdmin + ","
                + 0
                + ")"; 
            return query;
        }
        public bool UserExist()//check if there is a user with the same name in the DB
        {
            string query = "select Username from " + TableName + " where Username='" + Uname.Text + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object o = cmd.ExecuteScalar();
            string? pid = "";
            if (o != null) { pid = o.ToString(); }
            if(pid == Uname.Text)
            {
                return true;
            }
            return false;
        }
        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//click on delete
        {
            if (Uname.Text == "")//if name textbox is empty of text
            {
                MessageBox.Show("Please enter the employee ID");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "delete from " + TableName +
                                   " where Username='" + Uname.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully!");
                    connection.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}

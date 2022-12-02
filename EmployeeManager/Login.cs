using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManager.Properties;

namespace EmployeeManager
{
    //This is the login page.
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private string TableName = "Users";
        int IsAdmin;
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)//when the user click on 'login'
        {
            if (UIDbox.Text == "" || PASSbox.Text == "")//if one or more textbox is empty of text
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                string temp = "";
                connection.Open();
                string query = "select * from " + TableName + " where Username='" + UIDbox.Text + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)//if the user exist
                {
                    if(dt.Rows[0]["Password"].ToString() == PASSbox.Text)//if password is correct
                    {
                        temp = dt.Rows[0]["Username"].ToString();
                        Settings.Default["CURRENT_USER"] = temp;//update the current user settings 
                        Settings.Default.Save();
                        IsAdmin = Convert.ToInt32(dt.Rows[0]["IsAdmin"].ToString());
                        Home home = new Home(IsAdmin, dt.Rows[0]["Username"].ToString());
                        home.Show();
                        this.Hide();
                    }
                    else//if password isn't correct
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                }
                else//if the user doesn't exist
                {
                    MessageBox.Show("Wrong username or password");
                }
                connection.Close();
                UpdateConnection(temp);
            }
        }

        private void button1_Click(object sender, EventArgs e)//when the user click on 'clear'
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            UIDbox.Text = "";
            PASSbox.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)//when the user click on 'X'
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void UpdateConnection(string username)//this function updates the DB that the user connected
        {
            connection.Open();
            string query = "update " + TableName + " set Connected='1' where Username='" + username + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}

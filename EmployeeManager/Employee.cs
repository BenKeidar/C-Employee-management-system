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

namespace EmployeeManager
{
    //in this page the user can add / delete / update employees and see the employees on an organized table
    public partial class Employee : Form
    {
        private string TableName = "EmployeesTbl";
        int isAdmin;
        string name;
        public Employee(int x, string n)
        {
            isAdmin = x;
            name = n;
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)//click on add
        {
            if (fieldsIsValid())//if all fileds filled correctly by the user -> add the new employee
            {
                try
                {
                    connection.Open();
                    string query = buildInsertQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Employee seccessfully added!");
                    connection.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //this function checks if all fileds filled correctly by the user
        private bool fieldsIsValid()
        { 
            if (EmpID.Text == "" || EmpName.Text == "" || EmpAddress.Text == "" ||
                EmpPhone.Text == "" || EmpPosition.SelectedItem.ToString() == "" || 
                EmpEducation.SelectedItem.ToString() == "" ||
                EmpDOB.Value.Date.ToString() == "" || EmpGender.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please fill all fields");
                return false;
            }
            return true; 
        }

        private string buildInsertQuery()//builds query to add a new employee
        {
            string query = "insert into " + TableName + " values('"
                + EmpID.Text  +"','"
                + EmpName.Text + "','"
                + EmpAddress.Text + "','"
                + EmpDOB.Value.Date + "','"
                + EmpPhone.Text + "','"
                + EmpPosition.SelectedItem.ToString() + "','"
                + EmpEducation.SelectedItem.ToString() + "','"
                + EmpGender.SelectedItem.ToString()
                +"')"; ;
            return query;
        }
        private string buildUpdateQuery()//builds query to uptate an existing employee
        {
            string query = "update " + TableName + " set Name='"
                + EmpName.Text + "',Address='"
                + EmpAddress.Text + "',DOB='"
                + EmpDOB.Value.Date + "',Phone='"
                + EmpPhone.Text + "',Position='"
                + EmpPosition.SelectedItem.ToString() + "',Education='"
                + EmpEducation.SelectedItem.ToString() + "',Gender='"
                + EmpGender.SelectedItem.ToString()
                + "' where Id='" + EmpID.Text +"';";
            return query;
        }

        private void label10_Click(object sender, EventArgs e)//click on 'X'
        {
            Application.Exit();
        }

        //this function updates the employees table.
        private void Populate()
        {
            connection.Open();
            string query = "select * from " + TableName;
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlData);
            var ds = new DataSet();
            sqlData.Fill(ds);
            EmpGV.DataSource = ds.Tables[0];
            connection.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)//click on delete
        {
            if(EmpID.Text == "")//if the id textbox is empty of text
            {
                MessageBox.Show("Please enter the employee ID");
            }
            else
            { //delete the user from the DB
                try
                {
                    connection.Open();
                    string query = "delete from " + TableName +
                                   " where Id='" + EmpID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully!");
                    connection.Close();
                    Populate();
                }
                catch (Exception Ex){
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //when the user click on an employee from the table, this function set the employee details on the textboxes 
        private void EmpGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmpGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddress.Text = EmpGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmpGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhone.Text = EmpGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpPosition.Text = EmpGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpEducation.Text = EmpGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpGender.Text = EmpGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)//click on update
        {
            if (fieldsIsValid())//if all fileds filled correctly by the user -> update the new employee
            {
                try
                {
                    connection.Open();
                    string query = buildUpdateQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee seccessfully updated!");
                    connection.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//click on home
        {
            Home home = new Home(isAdmin, name);
            home.Show();
            this.Hide();
        }
    }
}

using EmployeeManager.Properties;
using System.Data.SqlClient;
using System.Data;
using EmployeeManager.Properties;

namespace EmployeeManager
{
    //This is the landing page.
    public partial class Splash : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\EmployeesDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private string TableName = "Users";
        int IsAdmin;
        int currentPoint = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPoint += 1;
            MyProgress.Value = currentPoint;//Progressbar progress.
            if(currentPoint == 104)//after Progressbar reachs 100%
            {     
                MyProgress.Value = 0;
                timer1.Stop();
                if (CheckIfConnected())//if the current user is connected -> go to home page
                {
                    this.Hide();
                    Home home = new Home(IsAdmin, Settings.Default["CURRENT_USER"].ToString());
                    home.Show();
                }
                else//if the current user is disconnected -> go to login page
                {
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }

            }
        }

        //this function checks in th DB if the current user is connected or not
        private bool CheckIfConnected()
        {
            connection.Open();
            string query = "select * from " + TableName + " where Username='" + Settings.Default["CURRENT_USER"] + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if (dt.Rows[0]["Connected"].ToString() == "1")
            {
                IsAdmin = Convert.ToInt32(dt.Rows[0]["IsAdmin"].ToString());
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
    }
}
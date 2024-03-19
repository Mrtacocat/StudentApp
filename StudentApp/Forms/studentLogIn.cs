using MySql.Data.MySqlClient;
using StudentApp.Database;
using System.Data;

namespace StudentApp.Forms
{
    public partial class studentLogIn : Form
    {
        private DBconnection dbConnection;
        public studentLogIn()
        {
            InitializeComponent();
            dbConnection = new DBconnection();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            int loggedIn = AuthenticateUser(username, password);



            if (loggedIn > 0)
            {
                this.Hide();
                studentpage studentpageform = new studentpage(loggedIn);
                studentpageform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private int AuthenticateUser(string username, string password)
        {
            try
            {
                dbConnection.OpenConnection();

                string query = "SELECT studentnr FROM studentLogin WHERE Brukernavn = @username AND Passord = @password";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0; // Return 0 hvis authentication feiler
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return 0; // Return 0 hvis det feiler
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}

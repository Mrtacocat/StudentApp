using MySql.Data.MySqlClient;
using StudentApp.Database;

namespace StudentApp.Forms
{
    public partial class studentpage : Form
    {
        private int loggedInStudentnr;


        public studentpage(int studentnr)
        {
            InitializeComponent();
            loggedInStudentnr = studentnr;
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            try
            {
                DBconnection dBConnection = new DBconnection();
                dBConnection.OpenConnection();

                string query = "SELECT studentnr, fornavn, etternavn, kjonn, fodt FROM students WHERE studentnr = @studentnr";
                using (MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@studentnr", loggedInStudentnr);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentnrTextField.Text = reader.GetString("studentnr");
                            fornavnTextField.Text = reader.GetString("fornavn");
                            etternavnTextField.Text = reader.GetString("etternavn");
                            kjonnTextField.Text = reader.GetString("kjonn");
                            fodtTextField.Text = reader.GetInt32("fodt").ToString();
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FEIL: Kunne ikke laste inn student" + "\n" + $"{ex.Message}");
            }
            finally
            {
                //dBConnection.CloseConnection();
            }
        }


        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnection dBConnection = new DBconnection();
                dBConnection.OpenConnection();

                // Update student information in the 'students' table
                string studentQuery = "UPDATE students SET fornavn = @fornavn, etternavn = @etternavn, kjonn = @kjonn, fodt = @fodt WHERE studentnr = @studentnr";
                using (MySqlCommand studentCmd = new MySqlCommand(studentQuery, dBConnection.Connection))
                {
                    studentCmd.Parameters.AddWithValue("@fornavn", fornavnTextField.Text);
                    studentCmd.Parameters.AddWithValue("@etternavn", etternavnTextField.Text);
                    studentCmd.Parameters.AddWithValue("@kjonn", kjonnTextField.Text);
                    studentCmd.Parameters.AddWithValue("@fodt", Convert.ToInt32(fodtTextField.Text));
                    studentCmd.Parameters.AddWithValue("@studentnr", loggedInStudentnr);

                    int studentRowsAffected = studentCmd.ExecuteNonQuery();

                    if (studentRowsAffected > 0)
                    {
                        MessageBox.Show("Student information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error updating student information.");
                    }
                }

                string userQuery = "UPDATE studentLogin SET Passord = @newPassword WHERE Studentnr = @studentnr";
                using (MySqlCommand userCmd = new MySqlCommand(userQuery, dBConnection.Connection))
                {
                    userCmd.Parameters.AddWithValue("@newPassword", newPasswordTextBox.Text);
                    userCmd.Parameters.AddWithValue("@studentnr", loggedInStudentnr); 

                    int userRowsAffected = userCmd.ExecuteNonQuery();

                    if (userRowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error updating password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
            finally
            {
                //dBConnection.CloseConnection();
            }
        }

        private void loggUt_Click(object sender, EventArgs e)
        {
            this.Hide();
            startpage startpageForm = new startpage();
            startpageForm.ShowDialog();
        }
    }
}

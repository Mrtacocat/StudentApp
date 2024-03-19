using MySql.Data.MySqlClient;
using StudentApp.Database;

namespace StudentApp
{
    public partial class LeggTil : Form
    {
        private ListBox listBox1;
        public LeggTil(ListBox listBox)
        {
            InitializeComponent();
            listBox1 = listBox;
        }
        private void studentNrTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void leggTilStudent_btn_Click(object sender, EventArgs e)
        {


            ListBox listBox = ((MittStudentRegister)Application.OpenForms["MittStudentRegister"]).ListBox1;

            string studentNr = studentNrTextBox.Text;
            string fornavn = fornavnTextBox.Text;
            string etternavn = etternavnTextBox.Text;
            string kjonn = kjonnTextBox.Text;
            string fodt = fodtTextBox.Text;
            string passord = passTextBox.Text;


            if (IsStudentNrTaken(int.Parse(studentNr)))
            {
                MessageBox.Show("StudentNr er allerede i bruk");
                return;
            }
            else
            {
                DBconnection dBConnection = new DBconnection();
                dBConnection.OpenConnection();

                Student student = new Student(fornavn, etternavn);

                student.StudentNr = int.Parse(studentNr);
                student.Fornavn = fornavn;
                student.Etternavn = etternavn;
                student.Kjønn = char.Parse(kjonn);
                student.FødtÅr = int.Parse(fodt);


                // Parameteriserer slik at du forhindrer SQL-injections
                string query1 = "INSERT INTO students (studentnr, fornavn, etternavn, kjonn, fodt) " +
                               "VALUES (@studentNr, @fornavn, @etternavn, @kjonn, @fodt);";

                string query2 = "INSERT INTO studentlogin (brukernavn, passord, studentnr)" +
                                "VALUES (@fornavn, @passord, @studentnr)";



                using (MySqlCommand cmd1 = new MySqlCommand(query1, dBConnection.Connection))
                using (MySqlCommand cmd2 = new MySqlCommand(query2, dBConnection.Connection))
                {
                    // Set parameter values
                    cmd1.Parameters.AddWithValue("@studentNr", student.StudentNr);
                    cmd1.Parameters.AddWithValue("@fornavn", student.Fornavn);
                    cmd1.Parameters.AddWithValue("@etternavn", student.Etternavn);
                    cmd1.Parameters.AddWithValue("@kjonn", student.Kjønn);
                    cmd1.Parameters.AddWithValue("@fodt", student.FødtÅr);

                    // Execute the insert query
                    int rowsAffected = cmd1.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Set parameters for the second query
                        cmd2.Parameters.AddWithValue("@fornavn", student.Fornavn);
                        cmd2.Parameters.AddWithValue("@etternavn", student.Etternavn);
                        cmd2.Parameters.AddWithValue("@studentnr", student.StudentNr);
                        cmd2.Parameters.AddWithValue("@passord", passord);

                        int rowsAffected2 = cmd2.ExecuteNonQuery();

                        if (rowsAffected2 > 0)
                        {
                            MessageBox.Show("Student records inserted successfully.");
                            listBox.Items.Add(student);
                        }
                        else
                        {
                            MessageBox.Show("Error inserting studentlogin record.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error inserting student record.");
                    }
                }
            }

            this.Close();
        }

        private bool IsStudentNrTaken(int studentNumber)
        {
            DBconnection dBConnection = new DBconnection();
            dBConnection.OpenConnection();

            string query = $"SELECT COUNT(*) FROM students WHERE studentnr = {studentNumber}";

            using (MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

using MySql.Data.MySqlClient;
using StudentApp.Database;
using StudentApp.Forms;
using System;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class MittStudentRegister : Form
    {
        public ListBox ListBox1
        {
            get { return listBox1; }
        }
        public MittStudentRegister()
        {
            InitializeComponent();


            DBconnection dBConnection = new DBconnection();

            dBConnection.OpenConnection();

            string query = "SELECT * FROM students;";
            using MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int studentnr = reader.GetInt32("studentnr");
                string fornavn = reader.GetString("fornavn");
                string etternavn = reader.GetString("etternavn");
                char kjonn = reader.GetChar("kjonn");
                int fodt = reader.GetInt32("fodt");

                Student student = new Student(fornavn, etternavn);
                student.StudentNr = studentnr;
                student.Fornavn = fornavn;
                student.Etternavn = etternavn;
                student.Kjønn = kjonn;
                student.FødtÅr = fodt;

                listBox1.Items.Add(student);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Student student = (Student)listBox1.SelectedItem;
                lblStudentNr.Text = student.StudentNr.ToString();
                lblNavn.Text = student.navn().ToString();
                lblKjonn.Text = student.Kjønn.ToString();
                lblFodt.Text = student.FødtÅr.ToString();
            }

        }

        private void leggTil_btn_Click(object sender, EventArgs e)
        {
            LeggTil leggTilForm = new LeggTil(ListBox1);
            leggTilForm.ShowDialog();
        }

        private void fjern_btn_Click(object sender, EventArgs e)
        {
            // Sjekker om et item er selected 
            if (listBox1.SelectedItem != null)
            {
                // Får selected student fra listen
                Student selectedStudent = (Student)listBox1.SelectedItem;

                // Henter student nummer slik at du kan fjerne
                int studentNrToDelete = selectedStudent.StudentNr;

                // Sletter det fra listbox1
                listBox1.Items.Remove(selectedStudent);

                // Sletter fra databasen
                DeleteStudentFromDatabase(studentNrToDelete);
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }

        private void DeleteStudentFromDatabase(int studentNrToDelete)
        {
            DBconnection dBConnection = new DBconnection();
            dBConnection.OpenConnection();

            string query1 = "DELETE FROM studentlogin WHERE studentnr = @studentNr";
            string query2 = "DELETE FROM students WHERE studentnr = @studentNr";

            using (MySqlCommand cmd1 = new MySqlCommand(query1, dBConnection.Connection))
            using (MySqlCommand cmd2 = new MySqlCommand(query2, dBConnection.Connection))
            {
                // Setter parameter verdier
                cmd1.Parameters.AddWithValue("@studentNr", studentNrToDelete);
                cmd2.Parameters.AddWithValue("@studentNr", studentNrToDelete);

                // Executer spørringene
                int rowsAffected1 = cmd1.ExecuteNonQuery();
                int rowsAffected2 = cmd2.ExecuteNonQuery();

                if (rowsAffected1 > 0 || rowsAffected2 > 0)
                {
                    MessageBox.Show("Student record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error deleting student record.");
                }
            }

            dBConnection.CloseConnection();
        }

        private void MittStudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            startpage startpageForm = new startpage();
            startpageForm.ShowDialog();
        }
    }
}
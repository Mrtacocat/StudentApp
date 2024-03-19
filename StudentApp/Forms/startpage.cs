using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp.Forms
{
    public partial class startpage : Form
    {
        public startpage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentLogIn studentLogInForm = new studentLogIn();
            studentLogInForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Holder i minne
            MittStudentRegister mittStudentRegisterForm = new MittStudentRegister();
            mittStudentRegisterForm.ShowDialog();
        }
    }
}

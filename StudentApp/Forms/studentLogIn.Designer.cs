namespace StudentApp.Forms
{
    partial class studentLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentLogIn));
            Login = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(325, 312);
            Login.Name = "Login";
            Login.Size = new Size(136, 47);
            Login.TabIndex = 0;
            Login.Text = "Logg inn";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Password
            // 
            Password.AccessibleDescription = "Password";
            Password.AccessibleName = "Password";
            Password.Location = new Point(291, 242);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Passord";
            Password.Size = new Size(209, 31);
            Password.TabIndex = 1;
            Password.Tag = "Password";
            // 
            // Username
            // 
            Username.AccessibleDescription = "Username";
            Username.AccessibleName = "Username";
            Username.Location = new Point(291, 177);
            Username.Name = "Username";
            Username.PlaceholderText = "Brukernavn";
            Username.Size = new Size(209, 31);
            Username.TabIndex = 2;
            Username.Tag = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 106);
            label1.Name = "label1";
            label1.Size = new Size(152, 48);
            label1.TabIndex = 3;
            label1.Text = "Student";
            // 
            // studentLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(Login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "studentLogIn";
            Text = "studentLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private TextBox Password;
        private TextBox Username;
        private Label label1;
    }
}
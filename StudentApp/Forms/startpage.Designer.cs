namespace StudentApp.Forms
{
    partial class startpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startpage));
            Menu = new Label();
            button2 = new Button();
            button3 = new Button();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.AutoSize = true;
            Menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Menu.Location = new Point(187, 9);
            Menu.Name = "Menu";
            Menu.Size = new Size(117, 48);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(165, 82);
            button2.Name = "button2";
            button2.Size = new Size(165, 49);
            button2.TabIndex = 0;
            button2.Text = "Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(165, 157);
            button3.Name = "button3";
            button3.Size = new Size(165, 49);
            button3.TabIndex = 2;
            button3.Text = "Lærer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // startpage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 280);
            Controls.Add(button3);
            Controls.Add(Menu);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "startpage";
            Text = "startpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Menu;
        private Button button2;
        private Button button3;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
    }
}
namespace StudentApp.Forms
{
    partial class studentpage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentpage));
            contextMenuStrip1 = new ContextMenuStrip(components);
            fontDialog1 = new FontDialog();
            label1 = new Label();
            studentnrTextField = new TextBox();
            fornavnTextField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            etternavnTextField = new TextBox();
            label4 = new Label();
            kjonnTextField = new TextBox();
            label5 = new Label();
            fodtTextField = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            saveChanges = new Button();
            label6 = new Label();
            newPasswordTextBox = new TextBox();
            loggUt = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "StudentNr:";
            // 
            // studentnrTextField
            // 
            studentnrTextField.Location = new Point(140, 12);
            studentnrTextField.Name = "studentnrTextField";
            studentnrTextField.ReadOnly = true;
            studentnrTextField.Size = new Size(150, 31);
            studentnrTextField.TabIndex = 2;
            // 
            // fornavnTextField
            // 
            fornavnTextField.Location = new Point(140, 100);
            fornavnTextField.Name = "fornavnTextField";
            fornavnTextField.ReadOnly = true;
            fornavnTextField.Size = new Size(150, 31);
            fornavnTextField.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Fornavn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 192);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "Etternavn:";
            // 
            // etternavnTextField
            // 
            etternavnTextField.Location = new Point(140, 186);
            etternavnTextField.Name = "etternavnTextField";
            etternavnTextField.ReadOnly = true;
            etternavnTextField.Size = new Size(150, 31);
            etternavnTextField.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 366);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 8;
            label4.Text = "Kjønn:";
            // 
            // kjonnTextField
            // 
            kjonnTextField.Location = new Point(140, 360);
            kjonnTextField.Name = "kjonnTextField";
            kjonnTextField.ReadOnly = true;
            kjonnTextField.Size = new Size(150, 31);
            kjonnTextField.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 278);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 10;
            label5.Text = "Født:";
            // 
            // fodtTextField
            // 
            fodtTextField.Location = new Point(140, 272);
            fodtTextField.Name = "fodtTextField";
            fodtTextField.ReadOnly = true;
            fodtTextField.Size = new Size(150, 31);
            fodtTextField.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // saveChanges
            // 
            saveChanges.Location = new Point(605, 360);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(150, 34);
            saveChanges.TabIndex = 11;
            saveChanges.Text = "Lagre endring";
            saveChanges.UseVisualStyleBackColor = true;
            saveChanges.Click += saveChanges_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 325);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 12;
            label6.Text = "Endre passord?";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.AccessibleDescription = "";
            newPasswordTextBox.AccessibleName = "";
            newPasswordTextBox.Location = new Point(424, 363);
            newPasswordTextBox.MaxLength = 20;
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.PlaceholderText = "Nytt passord";
            newPasswordTextBox.Size = new Size(150, 31);
            newPasswordTextBox.TabIndex = 13;
            newPasswordTextBox.Tag = "";
            // 
            // loggUt
            // 
            loggUt.Location = new Point(676, 9);
            loggUt.Name = "loggUt";
            loggUt.Size = new Size(112, 34);
            loggUt.TabIndex = 14;
            loggUt.Text = "Logg ut";
            loggUt.UseVisualStyleBackColor = true;
            loggUt.Click += loggUt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(466, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 238);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // studentpage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(pictureBox1);
            Controls.Add(loggUt);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label6);
            Controls.Add(saveChanges);
            Controls.Add(label5);
            Controls.Add(fodtTextField);
            Controls.Add(label4);
            Controls.Add(kjonnTextField);
            Controls.Add(label3);
            Controls.Add(etternavnTextField);
            Controls.Add(label2);
            Controls.Add(fornavnTextField);
            Controls.Add(studentnrTextField);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "studentpage";
            Text = "studentpage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private FontDialog fontDialog1;
        private Label label1;
        private TextBox studentnrTextField;
        private TextBox fornavnTextField;
        private Label label2;
        private Label label3;
        private TextBox etternavnTextField;
        private Label label4;
        private TextBox kjonnTextField;
        private Label label5;
        private TextBox fodtTextField;
        private NotifyIcon notifyIcon1;
        private Button saveChanges;
        private Label label6;
        private TextBox newPasswordTextBox;
        private Button loggUt;
        private PictureBox pictureBox1;
    }
}
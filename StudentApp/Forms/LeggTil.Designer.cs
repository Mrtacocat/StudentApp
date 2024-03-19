namespace StudentApp
{
    partial class LeggTil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeggTil));
            studentNrTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fornavnTextBox = new TextBox();
            label4 = new Label();
            etternavnTextBox = new TextBox();
            label5 = new Label();
            kjonnTextBox = new TextBox();
            label6 = new Label();
            fodtTextBox = new TextBox();
            leggTilStudent_btn = new Button();
            label7 = new Label();
            passTextBox = new TextBox();
            SuspendLayout();
            // 
            // studentNrTextBox
            // 
            studentNrTextBox.AccessibleDescription = "";
            studentNrTextBox.AccessibleName = "";
            studentNrTextBox.Location = new Point(57, 109);
            studentNrTextBox.Margin = new Padding(3, 4, 3, 4);
            studentNrTextBox.Name = "studentNrTextBox";
            studentNrTextBox.Size = new Size(195, 31);
            studentNrTextBox.TabIndex = 0;
            studentNrTextBox.Tag = "";
            studentNrTextBox.TextChanged += studentNrTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 80);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "StudentNr:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 25);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 2;
            label2.Text = "Legg til ny student";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Fornavn:";
            // 
            // fornavnTextBox
            // 
            fornavnTextBox.AccessibleDescription = "";
            fornavnTextBox.AccessibleName = "";
            fornavnTextBox.Location = new Point(57, 178);
            fornavnTextBox.Margin = new Padding(3, 4, 3, 4);
            fornavnTextBox.Name = "fornavnTextBox";
            fornavnTextBox.Size = new Size(195, 31);
            fornavnTextBox.TabIndex = 3;
            fornavnTextBox.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 220);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Etternavn:";
            // 
            // etternavnTextBox
            // 
            etternavnTextBox.AccessibleDescription = "";
            etternavnTextBox.AccessibleName = "";
            etternavnTextBox.Location = new Point(57, 249);
            etternavnTextBox.Margin = new Padding(3, 4, 3, 4);
            etternavnTextBox.Name = "etternavnTextBox";
            etternavnTextBox.Size = new Size(195, 31);
            etternavnTextBox.TabIndex = 5;
            etternavnTextBox.Tag = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 291);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 8;
            label5.Text = "Kjønn:";
            label5.Click += label5_Click;
            // 
            // kjonnTextBox
            // 
            kjonnTextBox.AccessibleDescription = "";
            kjonnTextBox.AccessibleName = "";
            kjonnTextBox.Location = new Point(57, 320);
            kjonnTextBox.Margin = new Padding(3, 4, 3, 4);
            kjonnTextBox.Name = "kjonnTextBox";
            kjonnTextBox.Size = new Size(195, 31);
            kjonnTextBox.TabIndex = 7;
            kjonnTextBox.Tag = "";
            kjonnTextBox.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 360);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 10;
            label6.Text = "Fødselsår:";
            // 
            // fodtTextBox
            // 
            fodtTextBox.AccessibleDescription = "";
            fodtTextBox.AccessibleName = "";
            fodtTextBox.Location = new Point(57, 389);
            fodtTextBox.Margin = new Padding(3, 4, 3, 4);
            fodtTextBox.Name = "fodtTextBox";
            fodtTextBox.Size = new Size(195, 31);
            fodtTextBox.TabIndex = 9;
            fodtTextBox.Tag = "";
            // 
            // leggTilStudent_btn
            // 
            leggTilStudent_btn.Location = new Point(91, 509);
            leggTilStudent_btn.Margin = new Padding(3, 4, 3, 4);
            leggTilStudent_btn.Name = "leggTilStudent_btn";
            leggTilStudent_btn.Size = new Size(142, 41);
            leggTilStudent_btn.TabIndex = 11;
            leggTilStudent_btn.Text = "Legg til";
            leggTilStudent_btn.UseVisualStyleBackColor = true;
            leggTilStudent_btn.Click += leggTilStudent_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 430);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 13;
            label7.Text = "Passord:";
            // 
            // passTextBox
            // 
            passTextBox.AccessibleDescription = "";
            passTextBox.AccessibleName = "";
            passTextBox.Location = new Point(58, 459);
            passTextBox.Margin = new Padding(3, 4, 3, 4);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(195, 31);
            passTextBox.TabIndex = 12;
            passTextBox.Tag = "";
            passTextBox.TextChanged += passTextBox_TextChanged;
            // 
            // LeggTil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 587);
            Controls.Add(label7);
            Controls.Add(passTextBox);
            Controls.Add(leggTilStudent_btn);
            Controls.Add(label6);
            Controls.Add(fodtTextBox);
            Controls.Add(label5);
            Controls.Add(kjonnTextBox);
            Controls.Add(label4);
            Controls.Add(etternavnTextBox);
            Controls.Add(label3);
            Controls.Add(fornavnTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(studentNrTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "LeggTil";
            Text = "LeggTil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentNrTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox fornavnTextBox;
        private Label label4;
        private TextBox etternavnTextBox;
        private Label label5;
        private TextBox kjonnTextBox;
        private Label label6;
        private TextBox fodtTextBox;
        private Button leggTilStudent_btn;
        private Label label7;
        private TextBox passTextBox;
    }
}
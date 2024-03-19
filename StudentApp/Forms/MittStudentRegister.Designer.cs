using System.Windows.Forms;

namespace StudentApp
{
    partial class MittStudentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MittStudentRegister));
            listBox1 = new ListBox();
            leggTil_btn = new Button();
            label1 = new Label();
            lblStudentNr = new Label();
            lblNavn = new Label();
            lblKjonn = new Label();
            lblFodt = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fjern_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            back_btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(64, 59);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(337, 479);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // leggTil_btn
            // 
            leggTil_btn.Location = new Point(462, 439);
            leggTil_btn.Margin = new Padding(3, 4, 3, 4);
            leggTil_btn.Name = "leggTil_btn";
            leggTil_btn.Size = new Size(128, 46);
            leggTil_btn.TabIndex = 3;
            leggTil_btn.Text = "Legg til";
            leggTil_btn.UseVisualStyleBackColor = true;
            leggTil_btn.Click += leggTil_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 11);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 5;
            label1.Text = "Studentregister";
            // 
            // lblStudentNr
            // 
            lblStudentNr.AutoSize = true;
            lblStudentNr.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentNr.Location = new Point(125, 0);
            lblStudentNr.Name = "lblStudentNr";
            lblStudentNr.Size = new Size(14, 20);
            lblStudentNr.TabIndex = 6;
            lblStudentNr.Tag = "isStudentNr";
            lblStudentNr.Text = "-";
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNavn.Location = new Point(125, 40);
            lblNavn.Name = "lblNavn";
            lblNavn.Size = new Size(14, 20);
            lblNavn.TabIndex = 7;
            lblNavn.Tag = "isNavn";
            lblNavn.Text = "-";
            // 
            // lblKjonn
            // 
            lblKjonn.AutoSize = true;
            lblKjonn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKjonn.Location = new Point(125, 80);
            lblKjonn.Name = "lblKjonn";
            lblKjonn.Size = new Size(14, 20);
            lblKjonn.TabIndex = 8;
            lblKjonn.Tag = "isKjonn";
            lblKjonn.Text = "-";
            // 
            // lblFodt
            // 
            lblFodt.AutoSize = true;
            lblFodt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFodt.Location = new Point(125, 120);
            lblFodt.Name = "lblFodt";
            lblFodt.Size = new Size(14, 20);
            lblFodt.TabIndex = 9;
            lblFodt.Tag = "isFodt";
            lblFodt.Text = "-";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 10;
            label2.Text = "StudentNr:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 11;
            label3.Text = "Navn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = "Kjønn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 13;
            label5.Text = "Født:";
            // 
            // fjern_btn
            // 
            fjern_btn.Location = new Point(462, 492);
            fjern_btn.Margin = new Padding(3, 4, 3, 4);
            fjern_btn.Name = "fjern_btn";
            fjern_btn.Size = new Size(128, 46);
            fjern_btn.TabIndex = 14;
            fjern_btn.Text = "Fjern";
            fjern_btn.UseVisualStyleBackColor = true;
            fjern_btn.Click += fjern_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4820862F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5179138F));
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lblStudentNr, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNavn, 1, 1);
            tableLayoutPanel1.Controls.Add(lblKjonn, 1, 2);
            tableLayoutPanel1.Controls.Add(lblFodt, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(64, 557);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 163);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(526, 9);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(112, 42);
            back_btn.TabIndex = 16;
            back_btn.Text = "Tilbake";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // MittStudentRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 759);
            Controls.Add(back_btn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(fjern_btn);
            Controls.Add(label1);
            Controls.Add(leggTil_btn);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MittStudentRegister";
            Text = "MittStudentRegister";
            Load += MittStudentRegister_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Button leggTil_btn;
        private Label label1;
        private Label lblStudentNr;
        private Label lblNavn;
        private Label lblKjonn;
        private Label lblFodt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button fjern_btn;
        public ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button back_btn;
    }
}
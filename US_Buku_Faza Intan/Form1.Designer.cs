namespace US_Buku_Faza_Intan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ID = new TextBox();
            Judul_Buku = new TextBox();
            Jenis_Buku = new TextBox();
            Stok = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            databuku = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databuku).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 118, 117);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1451, 200);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(916, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(46, 118, 117);
            label6.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(233, 239, 203);
            label6.Location = new Point(307, 71);
            label6.Name = "label6";
            label6.Size = new Size(596, 77);
            label6.TabIndex = 18;
            label6.Text = "Hayyi's Book Store";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(195, 114);
            ID.Name = "ID";
            ID.Size = new Size(248, 36);
            ID.TabIndex = 1;
            ID.TextChanged += textBox1_TextChanged;
            // 
            // Judul_Buku
            // 
            Judul_Buku.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Judul_Buku.Location = new Point(195, 168);
            Judul_Buku.Name = "Judul_Buku";
            Judul_Buku.Size = new Size(248, 36);
            Judul_Buku.TabIndex = 2;
            // 
            // Jenis_Buku
            // 
            Jenis_Buku.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Jenis_Buku.Location = new Point(195, 225);
            Jenis_Buku.Name = "Jenis_Buku";
            Jenis_Buku.Size = new Size(248, 36);
            Jenis_Buku.TabIndex = 3;
            // 
            // Stok
            // 
            Stok.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Stok.Location = new Point(195, 283);
            Stok.Name = "Stok";
            Stok.Size = new Size(248, 36);
            Stok.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 196, 179);
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 65, 86);
            label2.Location = new Point(45, 175);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 9;
            label2.Text = "Judul Buku :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 196, 179);
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 65, 86);
            label1.Location = new Point(45, 121);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 10;
            label1.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(139, 196, 179);
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 65, 86);
            label3.Location = new Point(45, 232);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 11;
            label3.Text = "Jenis Buku :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(139, 196, 179);
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 65, 86);
            label4.Location = new Point(45, 290);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 12;
            label4.Text = "Stok :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(139, 196, 179);
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 65, 86);
            label5.Location = new Point(45, 41);
            label5.Name = "label5";
            label5.Size = new Size(410, 36);
            label5.TabIndex = 13;
            label5.Text = "Masukkan Data Buku Disini-!";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 65, 86);
            button1.Location = new Point(236, 350);
            button1.Name = "button1";
            button1.Size = new Size(95, 47);
            button1.TabIndex = 14;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 196, 179);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Stok);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Jenis_Buku);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Judul_Buku);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(ID);
            panel2.Location = new Point(12, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 432);
            panel2.TabIndex = 16;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(30, 65, 86);
            button3.Location = new Point(348, 350);
            button3.Name = "button3";
            button3.Size = new Size(95, 47);
            button3.TabIndex = 16;
            button3.Text = "Simpan";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // databuku
            // 
            databuku.BackgroundColor = Color.FromArgb(233, 239, 203);
            databuku.BorderStyle = BorderStyle.None;
            databuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databuku.Location = new Point(534, 194);
            databuku.Name = "databuku";
            databuku.RowTemplate.Height = 25;
            databuku.Size = new Size(649, 432);
            databuku.TabIndex = 17;
            databuku.CellClick += databuku_CellClick;
            databuku.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1195, 641);
            Controls.Add(databuku);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databuku).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox ID;
        private TextBox Judul_Buku;
        private TextBox Jenis_Buku;
        private TextBox Stok;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Panel panel2;
        private Label label6;
        private Button button3;
        private PictureBox pictureBox3;
        private DataGridView databuku;
    }
}
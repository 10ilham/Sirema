namespace Sirema.antarmuka
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.nama_lbl = new Guna.UI.WinForms.GunaLabel();
            this.tanggal_lbl = new Guna.UI.WinForms.GunaLabel();
            this.jam_lbl = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Label1 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.mhs_btn = new System.Windows.Forms.Button();
            this.prodi_btn = new System.Windows.Forms.Button();
            this.jurusan_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.nama_lbl);
            this.panel1.Controls.Add(this.tanggal_lbl);
            this.panel1.Controls.Add(this.jam_lbl);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 138);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(279, 116);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(56, 25);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "User :";
            // 
            // nama_lbl
            // 
            this.nama_lbl.AutoSize = true;
            this.nama_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_lbl.Location = new System.Drawing.Point(341, 116);
            this.nama_lbl.Name = "nama_lbl";
            this.nama_lbl.Size = new System.Drawing.Size(75, 25);
            this.nama_lbl.TabIndex = 1;
            this.nama_lbl.Text = "Selamat";
            this.nama_lbl.Click += new System.EventHandler(this.nama_lbl_Click_1);
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lbl.Location = new System.Drawing.Point(177, 76);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(69, 23);
            this.tanggal_lbl.TabIndex = 3;
            this.tanggal_lbl.Text = "Tanggal";
            this.tanggal_lbl.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // jam_lbl
            // 
            this.jam_lbl.AutoSize = true;
            this.jam_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jam_lbl.Location = new System.Drawing.Point(177, 113);
            this.jam_lbl.Name = "jam_lbl";
            this.jam_lbl.Size = new System.Drawing.Size(72, 23);
            this.jam_lbl.TabIndex = 2;
            this.jam_lbl.Text = "00:00:00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Location = new System.Drawing.Point(181, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 45);
            this.panel4.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(444, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "SISTEM INFORMASI REGISTRASI MAHASISWA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.mhs_btn);
            this.panel2.Controls.Add(this.prodi_btn);
            this.panel2.Controls.Add(this.jurusan_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 490);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logout_btn.Location = new System.Drawing.Point(0, 457);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(181, 33);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // mhs_btn
            // 
            this.mhs_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mhs_btn.FlatAppearance.BorderSize = 0;
            this.mhs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.mhs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.mhs_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mhs_btn.Location = new System.Drawing.Point(0, 66);
            this.mhs_btn.Name = "mhs_btn";
            this.mhs_btn.Size = new System.Drawing.Size(181, 33);
            this.mhs_btn.TabIndex = 2;
            this.mhs_btn.Text = "Data Mahasiswa";
            this.mhs_btn.UseVisualStyleBackColor = true;
            // 
            // prodi_btn
            // 
            this.prodi_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodi_btn.FlatAppearance.BorderSize = 0;
            this.prodi_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.prodi_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.prodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prodi_btn.Location = new System.Drawing.Point(0, 33);
            this.prodi_btn.Name = "prodi_btn";
            this.prodi_btn.Size = new System.Drawing.Size(181, 33);
            this.prodi_btn.TabIndex = 1;
            this.prodi_btn.Text = "Data Prodi";
            this.prodi_btn.UseVisualStyleBackColor = true;
            this.prodi_btn.Click += new System.EventHandler(this.prodi_btn_Click);
            // 
            // jurusan_btn
            // 
            this.jurusan_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.jurusan_btn.FlatAppearance.BorderSize = 0;
            this.jurusan_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.jurusan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.jurusan_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.jurusan_btn.Location = new System.Drawing.Point(0, 0);
            this.jurusan_btn.Name = "jurusan_btn";
            this.jurusan_btn.Size = new System.Drawing.Size(181, 33);
            this.jurusan_btn.TabIndex = 0;
            this.jurusan_btn.Text = "Data Jurusan";
            this.jurusan_btn.UseVisualStyleBackColor = true;
            this.jurusan_btn.Click += new System.EventHandler(this.jurusan_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(181, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 490);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dashboard_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaLabel Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button jurusan_btn;
        private System.Windows.Forms.Button mhs_btn;
        private System.Windows.Forms.Button prodi_btn;
        private Guna.UI.WinForms.GunaLabel jam_lbl;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI.WinForms.GunaLabel tanggal_lbl;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button logout_btn;
        public Guna.UI.WinForms.GunaLabel nama_lbl;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel5;
    }
}
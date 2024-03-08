namespace Sirema
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kode_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Simpan = new System.Windows.Forms.Button();
            this.Nama_jurusan = new System.Windows.Forms.TextBox();
            this.Ubah = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Cari = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.jurusan_data = new System.Windows.Forms.DataGridView();
            this.c_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kode_txt
            // 
            this.kode_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kode_txt.Enabled = false;
            this.kode_txt.Location = new System.Drawing.Point(341, 178);
            this.kode_txt.Multiline = true;
            this.kode_txt.Name = "kode_txt";
            this.kode_txt.Size = new System.Drawing.Size(291, 30);
            this.kode_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Jurusan";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Jurusan";
            // 
            // Simpan
            // 
            this.Simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Simpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.Simpan.FlatAppearance.BorderSize = 0;
            this.Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Simpan.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simpan.ForeColor = System.Drawing.SystemColors.Control;
            this.Simpan.Location = new System.Drawing.Point(205, 289);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(79, 30);
            this.Simpan.TabIndex = 4;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = false;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Nama_jurusan
            // 
            this.Nama_jurusan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nama_jurusan.Location = new System.Drawing.Point(341, 231);
            this.Nama_jurusan.Multiline = true;
            this.Nama_jurusan.Name = "Nama_jurusan";
            this.Nama_jurusan.Size = new System.Drawing.Size(388, 30);
            this.Nama_jurusan.TabIndex = 3;
            // 
            // Ubah
            // 
            this.Ubah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ubah.BackColor = System.Drawing.Color.Yellow;
            this.Ubah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ubah.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ubah.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Ubah.Location = new System.Drawing.Point(301, 289);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(79, 30);
            this.Ubah.TabIndex = 6;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = false;
            this.Ubah.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(638, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hapus
            // 
            this.Hapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hapus.BackColor = System.Drawing.Color.Red;
            this.Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hapus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.Hapus.Location = new System.Drawing.Point(396, 289);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(79, 30);
            this.Hapus.TabIndex = 7;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Cari
            // 
            this.Cari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cari.AutoSize = true;
            this.Cari.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.Location = new System.Drawing.Point(201, 348);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(43, 21);
            this.Cari.TabIndex = 9;
            this.Cari.Text = "Cari";
            // 
            // cari_txt
            // 
            this.cari_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cari_txt.Location = new System.Drawing.Point(341, 339);
            this.cari_txt.Multiline = true;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(388, 30);
            this.cari_txt.TabIndex = 8;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // batal_btn
            // 
            this.batal_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batal_btn.BackColor = System.Drawing.Color.DarkGray;
            this.batal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.batal_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.batal_btn.Location = new System.Drawing.Point(493, 289);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(79, 30);
            this.batal_btn.TabIndex = 12;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // tutup_btn
            // 
            this.tutup_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tutup_btn.BackColor = System.Drawing.Color.Gray;
            this.tutup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tutup_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutup_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.tutup_btn.Location = new System.Drawing.Point(588, 289);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(79, 30);
            this.tutup_btn.TabIndex = 13;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = false;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // gunaColorTransition1
            // 
            this.gunaColorTransition1.AutoTransition = true;
            this.gunaColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.Wheat};
            this.gunaColorTransition1.EndColor = System.Drawing.Color.Linen;
            this.gunaColorTransition1.ProgessValue = 2;
            this.gunaColorTransition1.StartColor = System.Drawing.Color.Aqua;
            this.gunaColorTransition1.ValueChanged += new System.EventHandler(this.gunaColorTransition1_ValueChanged);
            // 
            // jurusan_data
            // 
            this.jurusan_data.AllowUserToAddRows = false;
            this.jurusan_data.AllowUserToDeleteRows = false;
            this.jurusan_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jurusan_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusan_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_kode,
            this.c_nama});
            this.jurusan_data.Location = new System.Drawing.Point(0, 458);
            this.jurusan_data.Name = "jurusan_data";
            this.jurusan_data.ReadOnly = true;
            this.jurusan_data.RowHeadersWidth = 51;
            this.jurusan_data.RowTemplate.Height = 24;
            this.jurusan_data.Size = new System.Drawing.Size(1059, 189);
            this.jurusan_data.TabIndex = 11;
            this.jurusan_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_data_CellClick);
            this.jurusan_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_data_CellContentClick);
            // 
            // c_kode
            // 
            this.c_kode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_kode.DataPropertyName = "kode_jurusan";
            this.c_kode.HeaderText = "Kode_Jurusan";
            this.c_kode.MinimumWidth = 6;
            this.c_kode.Name = "c_kode";
            this.c_kode.ReadOnly = true;
            // 
            // c_nama
            // 
            this.c_nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_nama.DataPropertyName = "nama_jurusan";
            this.c_nama.HeaderText = "Nama_Jurusan";
            this.c_nama.MinimumWidth = 6;
            this.c_nama.Name = "c_nama";
            this.c_nama.ReadOnly = true;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(427, 32);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(126, 98);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 14;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(436, 144);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 31);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "SIREMA";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.jurusan_data);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.tutup_btn);
            this.panel1.Controls.Add(this.batal_btn);
            this.panel1.Controls.Add(this.Cari);
            this.panel1.Controls.Add(this.cari_txt);
            this.panel1.Controls.Add(this.Hapus);
            this.panel1.Controls.Add(this.Ubah);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Simpan);
            this.panel1.Controls.Add(this.Nama_jurusan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.kode_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 685);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 685);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jurusan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kode_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.TextBox Nama_jurusan;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Label Cari;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button tutup_btn;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private System.Windows.Forms.DataGridView jurusan_data;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama;
        private System.Windows.Forms.Panel panel1;
    }
}


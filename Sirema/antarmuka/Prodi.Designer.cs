namespace Sirema.antarmuka
{
    partial class Prodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.namajurusan_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodi_dgv = new System.Windows.Forms.DataGridView();
            this.c_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.tutupprodi_btn = new System.Windows.Forms.Button();
            this.batalprodi_btn = new System.Windows.Forms.Button();
            this.Cari = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.hapusprodi_btn = new System.Windows.Forms.Button();
            this.ubahprodi_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.simpanprodi_btn = new System.Windows.Forms.Button();
            this.namaprodi_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kodeprodi_txt = new System.Windows.Forms.TextBox();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.namajurusan_cmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prodi_dgv);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.tutupprodi_btn);
            this.panel1.Controls.Add(this.batalprodi_btn);
            this.panel1.Controls.Add(this.Cari);
            this.panel1.Controls.Add(this.cari_txt);
            this.panel1.Controls.Add(this.hapusprodi_btn);
            this.panel1.Controls.Add(this.ubahprodi_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.simpanprodi_btn);
            this.panel1.Controls.Add(this.namaprodi_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kodeprodi_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 716);
            this.panel1.TabIndex = 17;
            // 
            // namajurusan_cmb
            // 
            this.namajurusan_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namajurusan_cmb.FormattingEnabled = true;
            this.namajurusan_cmb.Location = new System.Drawing.Point(316, 278);
            this.namajurusan_cmb.Name = "namajurusan_cmb";
            this.namajurusan_cmb.Size = new System.Drawing.Size(387, 24);
            this.namajurusan_cmb.TabIndex = 19;
            this.namajurusan_cmb.SelectedIndexChanged += new System.EventHandler(this.namajurusan_cmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nama Jurusan";
            // 
            // prodi_dgv
            // 
            this.prodi_dgv.AllowUserToAddRows = false;
            this.prodi_dgv.AllowUserToDeleteRows = false;
            this.prodi_dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodi_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_kode,
            this.c_prodi,
            this.c_jurusan});
            this.prodi_dgv.Location = new System.Drawing.Point(0, 494);
            this.prodi_dgv.Name = "prodi_dgv";
            this.prodi_dgv.ReadOnly = true;
            this.prodi_dgv.RowHeadersWidth = 51;
            this.prodi_dgv.RowTemplate.Height = 24;
            this.prodi_dgv.Size = new System.Drawing.Size(932, 198);
            this.prodi_dgv.TabIndex = 16;
            this.prodi_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodi_dgv_CellClick);
            // 
            // c_kode
            // 
            this.c_kode.DataPropertyName = "kode_prodi";
            this.c_kode.HeaderText = "Kode Prodi";
            this.c_kode.MinimumWidth = 6;
            this.c_kode.Name = "c_kode";
            this.c_kode.ReadOnly = true;
            this.c_kode.Width = 250;
            // 
            // c_prodi
            // 
            this.c_prodi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_prodi.DataPropertyName = "nama_prodi";
            this.c_prodi.HeaderText = "Nama Prodi";
            this.c_prodi.MinimumWidth = 6;
            this.c_prodi.Name = "c_prodi";
            this.c_prodi.ReadOnly = true;
            // 
            // c_jurusan
            // 
            this.c_jurusan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_jurusan.DataPropertyName = "nama_jurusan";
            this.c_jurusan.HeaderText = "Nama Jurusan";
            this.c_jurusan.MinimumWidth = 6;
            this.c_jurusan.Name = "c_jurusan";
            this.c_jurusan.ReadOnly = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(410, 124);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 31);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "SIREMA";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(401, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(126, 98);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 14;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // tutupprodi_btn
            // 
            this.tutupprodi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tutupprodi_btn.BackColor = System.Drawing.Color.Gray;
            this.tutupprodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tutupprodi_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupprodi_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.tutupprodi_btn.Location = new System.Drawing.Point(561, 337);
            this.tutupprodi_btn.Name = "tutupprodi_btn";
            this.tutupprodi_btn.Size = new System.Drawing.Size(79, 30);
            this.tutupprodi_btn.TabIndex = 13;
            this.tutupprodi_btn.Text = "Tutup";
            this.tutupprodi_btn.UseVisualStyleBackColor = false;
            this.tutupprodi_btn.Click += new System.EventHandler(this.tutupprodi_btn_Click);
            // 
            // batalprodi_btn
            // 
            this.batalprodi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batalprodi_btn.BackColor = System.Drawing.Color.DarkGray;
            this.batalprodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.batalprodi_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalprodi_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.batalprodi_btn.Location = new System.Drawing.Point(466, 337);
            this.batalprodi_btn.Name = "batalprodi_btn";
            this.batalprodi_btn.Size = new System.Drawing.Size(79, 30);
            this.batalprodi_btn.TabIndex = 12;
            this.batalprodi_btn.Text = "Batal";
            this.batalprodi_btn.UseVisualStyleBackColor = false;
            this.batalprodi_btn.Click += new System.EventHandler(this.batalprodi_btn_Click);
            // 
            // Cari
            // 
            this.Cari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cari.AutoSize = true;
            this.Cari.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.Location = new System.Drawing.Point(174, 396);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(43, 21);
            this.Cari.TabIndex = 9;
            this.Cari.Text = "Cari";
            // 
            // cari_txt
            // 
            this.cari_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cari_txt.Location = new System.Drawing.Point(314, 387);
            this.cari_txt.Multiline = true;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(388, 30);
            this.cari_txt.TabIndex = 8;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // hapusprodi_btn
            // 
            this.hapusprodi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hapusprodi_btn.BackColor = System.Drawing.Color.Red;
            this.hapusprodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hapusprodi_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusprodi_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.hapusprodi_btn.Location = new System.Drawing.Point(369, 337);
            this.hapusprodi_btn.Name = "hapusprodi_btn";
            this.hapusprodi_btn.Size = new System.Drawing.Size(79, 30);
            this.hapusprodi_btn.TabIndex = 7;
            this.hapusprodi_btn.Text = "Hapus";
            this.hapusprodi_btn.UseVisualStyleBackColor = false;
            this.hapusprodi_btn.Click += new System.EventHandler(this.hapusprodi_btn_Click);
            // 
            // ubahprodi_btn
            // 
            this.ubahprodi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ubahprodi_btn.BackColor = System.Drawing.Color.Yellow;
            this.ubahprodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ubahprodi_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubahprodi_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ubahprodi_btn.Location = new System.Drawing.Point(274, 337);
            this.ubahprodi_btn.Name = "ubahprodi_btn";
            this.ubahprodi_btn.Size = new System.Drawing.Size(79, 30);
            this.ubahprodi_btn.TabIndex = 6;
            this.ubahprodi_btn.Text = "Ubah";
            this.ubahprodi_btn.UseVisualStyleBackColor = false;
            this.ubahprodi_btn.Click += new System.EventHandler(this.ubahprodi_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Prodi";
            // 
            // simpanprodi_btn
            // 
            this.simpanprodi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpanprodi_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.simpanprodi_btn.FlatAppearance.BorderSize = 0;
            this.simpanprodi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simpanprodi_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanprodi_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.simpanprodi_btn.Location = new System.Drawing.Point(178, 337);
            this.simpanprodi_btn.Name = "simpanprodi_btn";
            this.simpanprodi_btn.Size = new System.Drawing.Size(79, 30);
            this.simpanprodi_btn.TabIndex = 4;
            this.simpanprodi_btn.Text = "Simpan";
            this.simpanprodi_btn.UseVisualStyleBackColor = false;
            this.simpanprodi_btn.Click += new System.EventHandler(this.simpanprodi_btn_Click);
            // 
            // namaprodi_txt
            // 
            this.namaprodi_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namaprodi_txt.Location = new System.Drawing.Point(315, 211);
            this.namaprodi_txt.Multiline = true;
            this.namaprodi_txt.Name = "namaprodi_txt";
            this.namaprodi_txt.Size = new System.Drawing.Size(388, 30);
            this.namaprodi_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Prodi";
            // 
            // kodeprodi_txt
            // 
            this.kodeprodi_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kodeprodi_txt.Enabled = false;
            this.kodeprodi_txt.Location = new System.Drawing.Point(315, 158);
            this.kodeprodi_txt.Multiline = true;
            this.kodeprodi_txt.Name = "kodeprodi_txt";
            this.kodeprodi_txt.Size = new System.Drawing.Size(387, 30);
            this.kodeprodi_txt.TabIndex = 0;
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
            // Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 716);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Prodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prodi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Prodi_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Button tutupprodi_btn;
        private System.Windows.Forms.Button batalprodi_btn;
        private System.Windows.Forms.Label Cari;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Button hapusprodi_btn;
        private System.Windows.Forms.Button ubahprodi_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button simpanprodi_btn;
        private System.Windows.Forms.TextBox namaprodi_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodeprodi_txt;
        private System.Windows.Forms.DataGridView prodi_dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jurusan;
        private System.Windows.Forms.ComboBox namajurusan_cmb;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
    }
}
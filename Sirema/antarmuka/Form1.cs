using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema
{
    using model;
    public partial class Form1 : Form
    {
        JurusanCls jurusan = new JurusanCls();

        public Form1()
        {
            InitializeComponent();
        }

        //void tampilGrid()
        //{
        //    jurusan_data.DataSource = jurusan.tampilkanSemua();
        //}

        // Untuk menampilkan data pada DataGridView
        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                jurusan_data.DataSource = jurusan.tampilkanSemua(); // Menampilkan semua data
            }
            else
            {
                //Versi ERROR
                //jurusan_data.DataSource = jurusan.cariDgNama(cari_txt.Text); // Menampilkan data berdasarkan nama
                //jurusan_data.DataSource = jurusan.cariDgKode(cari_txt.Text); // Menampilkan data berdasarkan kode

                DataTable hasilNama = jurusan.cariDgNama(cari_txt.Text); // Menampilkan data berdasarkan nama
                DataTable hasilKode = jurusan.cariDgKode(cari_txt.Text); // Menampilkan data berdasarkan kode

                // Gabungkan hasil pencarian berdasarkan nama dan kode
                DataTable gabungan = new DataTable();
                gabungan.Merge(hasilNama);
                gabungan.Merge(hasilKode);


                // Setel gabungan hasil pencarian sebagai DataSource
                jurusan_data.DataSource = gabungan;
            } 
            belangBelang(jurusan_data);
        }

        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
                    {
                        kolom.Style.BackColor = Color.Yellow;
                    }
                    else
                        kolom.Style.BackColor = Color.LightGreen;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kode_txt.Text))
            {
                MessageBox.Show("Data sudah ada");
            }
            else
            {
                MessageBox.Show("Data belum ada");
            }

        }

        // Untuk mengosongkan textbox
        void bersihkan()
        {
            kode_txt.Text = jurusan.buatKode();
            Nama_jurusan.Clear();
            // kode_txt.Clear();
            Nama_jurusan.Focus();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (!jurusan.apakahAda(kode_txt.Text))
            {
                jurusan.Kode_jurusan = kode_txt.Text;
                jurusan.Nama_jurusan = Nama_jurusan.Text;
                if (jurusan.simpanData() >= 0)
                {
                    MessageBox.Show("Data berhasil disimpan",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kode_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan",
                        "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bersihkan();
                    kode_txt.Focus();
                }
            }

            // Untuk mengubah data pada tombol simpan jadi tombol simpan bisa ada 2 fungsi untuk simpan dan ubah
            // else
            // {
            //  if (MessageBox.Show("Data sudah ada, apakah yakin akan diubah?",
            // "Konfirmasi", MessageBoxButtons.YesNo,
            // MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            // jurusan.Nama_jurusan = Nama_jurusan.Text;
            //if (jurusan.ubahData(kode_txt.Text) >= 0)
            //{
            //MessageBox.Show("Data berhasil diubah",
            //"INFORMASI", MessageBoxButtons.OK,
            //MessageBoxIcon.Information);
            //kode_txt.Focus();
            //}
            //else
            // {
            //MessageBox.Show("Data gagal diubah",
            // "ERROR", MessageBoxButtons.OK,
            //MessageBoxIcon.Error);
            //kode_txt.Focus();
            // }
            // }
            //}
        } //akhir method simpan

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kode_txt.Text))
            {
                //Untuk pertanyaan apakah yakin akan mengubah data
                if (MessageBox.Show("Data sudah ada, apakah yakin akan diubah?",
                    "Konfirmasi", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)

                //jurusan.Kode_jurusan = kode_txt.Text;
                jurusan.Nama_jurusan = Nama_jurusan.Text;
                if (jurusan.ubahData(kode_txt.Text) >= 0)
                {
                    //sebagai pesan jika data berhasil diubah
                    MessageBox.Show("Data berhasil diubah",
                          "INFORMASI", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                    bersihkan();
                    kode_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    //sebagai pesan jika data gagal diubah
                    MessageBox.Show("Data gagal diubah",
                           "ERROR", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    bersihkan();
                    kode_txt.Focus();
                }
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if (jurusan.apakahAda(kode_txt.Text))
            {
                //Untuk pertanyaan apakah yakin akan menghapus data
                if (MessageBox.Show("Data sudah ada, apakah yakin akan dihapus?",
                    "Konfirmasi", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (jurusan.hapusData(kode_txt.Text) >= 0)
                    {
                        //sebagai pesan jika data berhasil dihapus
                        MessageBox.Show("Data berhasil dihapus",
                              "INFORMASI", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                        bersihkan();
                        kode_txt.Focus();
                        tampilGrid();
                    }
                    else
                    {
                        //sebagai pesan jika data gagal dihapus
                        MessageBox.Show("Data gagal dihapus",
                               "ERROR", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                        kode_txt.Focus();
                    }
                }
            }
        }

        // Method untuk menangani perubahan nilai pada gunaColorTransition1
        private void gunaColorTransition1_ValueChanged(object sender, EventArgs e)
        {
            // Gunakan nilai dari gunaColorTransition1 untuk mengubah properti warna DataGridView
            // Misalnya, ubah warna latar belakang dan warna teks dari DefaultCellStyle
            this.BackColor = gunaColorTransition1.Value;

            // jurusan_data.DefaultCellStyle.BackColor = gunaColorTransition1.Value;
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        // Method untuk menangani perubahan nilai pada cari_txt
        private void jurusan_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.jurusan_data.Rows[e.RowIndex];
                kode_txt.Text = baris.Cells[0].Value.ToString();
                Nama_jurusan.Text = baris.Cells[1].Value.ToString();
            }
        }

        // Method Untuk Shortcut Keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                Simpan.PerformClick();
            }
            else if (e.KeyCode == Keys.D && e.Control)
            {
                Hapus.PerformClick();
            }
        }

        // Method untuk menangani perubahan nilai pada cari_txt
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin akan keluar?", 
                "Konfirmasi", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void jurusan_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

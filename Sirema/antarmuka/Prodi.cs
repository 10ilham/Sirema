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

namespace Sirema.antarmuka
{
    using model;
    public partial class Prodi : Form
    {
        ProdiCls prodi = new ProdiCls();
        public Prodi()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                prodi_dgv.DataSource = prodi.tampilkanSemua(); // Menampilkan semua data
            }
            else
            {

                prodi_dgv.DataSource = prodi.cariDgNama(cari_txt.Text);
            }
            belangBelang(prodi_dgv);
        }

        void combo()
        {
            
            DataTable jurusandata = prodi.isicombo();
            namajurusan_cmb.DataSource = jurusandata;

            namajurusan_cmb.DisplayMember = "nama_jurusan";
            namajurusan_cmb.ValueMember = "nama_jurusan";
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


        private void Prodi_Load(object sender, EventArgs e)
        {
            tampilGrid();
            combo();
            bersihkan();
        }

        void bersihkan()
        {
            kodeprodi_txt.Text = prodi.buatKode();
            namaprodi_txt.Clear();
            namajurusan_cmb.Focus();
        }

        private void simpanprodi_btn_Click(object sender, EventArgs e)
        {
            if(!prodi.apakahAda(kodeprodi_txt.Text))
            {
                prodi.Kode_prodi = kodeprodi_txt.Text;
                prodi.Nama_prodi = namaprodi_txt.Text;
                prodi.Nama_jurusan = namajurusan_cmb.Text;
                if (prodi.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kodeprodi_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan",
                        "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bersihkan();
                    kodeprodi_txt.Focus();
                }
            }
        }

        private void ubahprodi_btn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(kodeprodi_txt.Text))
            {
                if (MessageBox.Show("Data sudah ada, apakah yakin akan diubah?",
                   "Konfirmasi", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)

                   prodi.Nama_prodi = namaprodi_txt.Text;
                if (prodi.ubahData(kodeprodi_txt.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah",
                                               "INFORMASI", MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Information);
                    bersihkan();
                    kodeprodi_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal diubah",
                                               "ERROR", MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Error);
                    bersihkan();
                    kodeprodi_txt.Focus();
                }
            }
        }

        private void hapusprodi_btn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(kodeprodi_txt.Text))
            {
                if (MessageBox.Show("Data sudah ada, apakah yakin akan dihapus?",
                                       "Konfirmasi", MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (prodi.hapusData(kodeprodi_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus",
                                                       "INFORMASI", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Information);
                        bersihkan();
                        kodeprodi_txt.Focus();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus",
                                                       "ERROR", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Error);
                        kodeprodi_txt.Focus();
                    }
                }
            }
        }

        private void batalprodi_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void prodi_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.prodi_dgv.Rows[e.RowIndex];
                kodeprodi_txt.Text = baris.Cells[0].Value.ToString();
                namaprodi_txt.Text = baris.Cells[1].Value.ToString();
                namajurusan_cmb.Text = baris.Cells[2].Value.ToString();
            }
        }

        private void Prodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                simpanprodi_btn.PerformClick();
            }
            else if (e.KeyCode == Keys.D && e.Control)
            {
                hapusprodi_btn.PerformClick();
            }
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void tutupprodi_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                               "Konfirmasi", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void namajurusan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaColorTransition1_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = gunaColorTransition1.Value;
        }
    }
}

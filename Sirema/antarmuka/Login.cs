using Sirema.antarmuka;
using Sirema.model;
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
    // Kelas ini digunakan untuk menangani autentikasi pengguna
    public partial class Login : Form
    {
        // Konstruktor kelas Login
        public Login()
        {
            InitializeComponent();
        }

        // Handler ketika tombol pada keyboard ditekan
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol Enter ditekan, panggil metode Login_btn_Click
            if (e.KeyChar == 13)
            {
                Login_btn.PerformClick(); //PerformsClick() digunakan untuk memanggil event Click pada tombol
            }
            // Jika tombol Esc ditekan, panggil metode Exit_btn_Click
            else if (e.KeyChar == 27)
            {
                Exit_btn.PerformClick(); //PerformsClick() digunakan untuk memanggil event Click pada tombol
            }
        }

        // Tombol Login untuk masuk ke aplikasi Sirema
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string userId = User_id.Text; // Mengambil user ID dari input pengguna
            string password = Password.Text; // Mengambil password dari input pengguna

            LoginCLs loginCls = new LoginCLs(); // Membuat objek LoginCLs untuk melakukan autentikasi

            // Memanggil metode cekLogin untuk memeriksa autentikasi
            bool isAuthenticated = loginCls.cekLogin(userId, password);

            if (isAuthenticated)
            {
                // Jika autentikasi berhasil, tampilkan dashboard
                Dashboard dashboard = new Dashboard();
                dashboard.nama_lbl.Text = loginCls.GetNamaPengguna(userId, password);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // Jika autentikasi gagal, tampilkan pesan kesalahan
                MessageBox.Show("Maaf, User ID atau Password Anda Salah.",
                                "Kesalahan", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                User_id.Focus();
                User_id.SelectAll();
            }
        }

        // Tombol Keluar untuk keluar dari aplikasi
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            // Konfirmasi sebelum keluar dari aplikasi
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi jika tombol 'Yes' ditekan
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

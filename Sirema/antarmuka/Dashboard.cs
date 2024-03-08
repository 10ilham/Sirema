using Microsoft.VisualBasic.ApplicationServices;
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

namespace Sirema.antarmuka
{
    public partial class Dashboard : Form
    {
        int geser = 0;

        public object User_id { get; internal set; }

        public Dashboard()
        {
            InitializeComponent();
            //nama_lbl.Text = "Welcome, " + namaPengguna;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geser += 5;
            if (geser >= 100)
            {
                geser = -500;
            }
            Label1.Left = geser;
        }

        private void jurusan_btn_Click(object sender, EventArgs e)
        {
            Form1 jurusan = new Form1();
            jurusan.TopLevel = false;
            panel3.Controls.Add(jurusan);
            jurusan.Show();
            jurusan.FormBorderStyle = FormBorderStyle.None; // Menghilangkan border pada Form1
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            jam_lbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tanggal_lbl.Text = DateTime.Now.ToLongDateString();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            
            // Konfirmasi sebelum keluar dari aplikasi
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close(); // Keluar dari aplikasi jika tombol 'Yes' ditekan
            }
        }

        private void Dashboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol Enter ditekan, panggil metode Login_btn_Click
            //if (e.KeyChar == 13)
            //{
            //    Login_btn.PerformClick(); //PerformsClick() digunakan untuk memanggil event Click pada tombol
            //}
            // Jika tombol Esc ditekan, panggil metode Exit_btn_Click
             if (e.KeyChar == 27)
            {
                logout_btn.PerformClick(); //PerformsClick() digunakan untuk memanggil event Click pada tombol
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void nama_lbl_Click_1(object sender, EventArgs e)
        {

        }

        private void prodi_btn_Click(object sender, EventArgs e)
        {
            Prodi prodi = new Prodi();
            prodi.TopLevel = false;
            panel3.Controls.Add(prodi);
            prodi.Show();
            prodi.FormBorderStyle = FormBorderStyle.None; // Menghilangkan border pada Form1
        }
    }
}

using Sirema.konfigurasi; // Menggunakan namespace Sirema.konfigurasi
using System; // Menggunakan namespace System
using System.Collections.Generic; // Menggunakan namespace System.Collections.Generic
using System.Data; // Menggunakan namespace System.Data
using System.Linq; // Menggunakan namespace System.Linq
using System.Text; // Menggunakan namespace System.Text
using System.Threading.Tasks; // Menggunakan namespace System.Threading.Tasks

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema.model // Mendefinisikan namespace Sirema.model
{
    internal class LoginCLs // Mendefinisikan kelas internal LoginCLs
    {
        //Atribut
        private string user_id; // Mendefinisikan variabel private user_id
        private string password; // Mendefinisikan variabel private password

        KoneksiCls koneksi; // Mendefinisikan variabel koneksi dari tipe KoneksiCls
        DataTable temp; // Mendefinisikan variabel temp dari tipe DataTable
        string query; // Mendefinisikan variabel query dari tipe string

        public LoginCLs() // Konstruktor kelas LoginCLs
        {
            user_id = ""; // Menginisialisasi user_id dengan string kosong
            password = ""; // Menginisialisasi password dengan string kosong

            koneksi = new KoneksiCls(); // Membuat objek baru dari kelas KoneksiCls
            temp = new DataTable(); // Membuat objek baru dari kelas DataTable
            query = ""; // Menginisialisasi query dengan string kosong
        }

        public string User_id // Property User_id untuk set nilai user_id
        {
            set { user_id = value; } // Mengatur nilai user_id
        }

        public string Password // Property Password untuk set nilai password
        {
            set { password = value; } // Mengatur nilai password
        }

        //Ngecek apakah user_id sama password sudah ada atau belum pada database
        public bool cekLogin(string user, string pass) // Metode untuk memeriksa login
        {
            bool cek = false; // Mendefinisikan variabel cek dan menginisialisasi dengan false
            // Membuat query SQL untuk memeriksa user dan password di database
            query = "SELECT * FROM pengguna WHERE user_id = '" + user + "' AND password = '" + pass + "'";
            temp = koneksi.eksekusiQuery(query); // Menjalankan query dan menyimpan hasilnya di temp

            if (temp.Rows.Count > 0) // Jika ada baris di temp (artinya user dan password ada di database)
            {
                cek = true; // Mengatur cek menjadi true
            }

            return cek; // Mengembalikan nilai cek
        }

        public string GetNamaPengguna(string user, string pass)
        {
            string namaPengguna = ""; // Inisialisasi nama pengguna

            // Query SQL untuk mengambil nama pengguna berdasarkan user_id
            query = "SELECT nama_pengguna FROM pengguna WHERE user_id = '" + user + "' and password='" + pass+"'";
            temp = koneksi.eksekusiQuery(query); // Eksekusi query

            // Periksa apakah hasil query tidak kosong
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    namaPengguna = row[0].ToString(); // Ambil nama pengguna dari hasil query
                }
            }

            return namaPengguna; // Kembalikan nama pengguna
        }

    }
}

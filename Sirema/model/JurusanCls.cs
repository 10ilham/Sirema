using Sirema.konfigurasi; //Menambahkan namespace konfigurasi pada folder konfigurasi
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema.model
{
    internal class JurusanCls
    {
        //Atribut
        private string kode_jurusan;
        private string nama_jurusan;

       
        KoneksiCls koneksi;
        DataTable temp;
        string query; //untuk Insert, Update, Delete


        //Constructor
        public JurusanCls()
        {
            kode_jurusan = "";
            nama_jurusan = "";

            koneksi = new KoneksiCls();
            temp = new DataTable();
            query = "";
        }

        // Property
        public string Kode_jurusan
        {
            set { kode_jurusan = value; } //Accessor Method atau mengambil data
            //get { return kode_jurusan; } //Mutator Method atau memodifikasi data
        }

        public string Nama_jurusan
        {
            set { nama_jurusan = value; } //Accessor Method atau mengambil data
           // get { return nama_jurusan; } //Mutator Method atau memodifikasi data
        }

        //Ngecek apakah data sudah ada atau belum pada database
        public bool apakahAda(string kode)
        {
            bool cek = false; //Inisialisasi cek tipe boolean
            query = "SELECT * FROM jurusan WHERE kode_jurusan = '" + kode + "'"; // Query untuk mengecek data
            temp = koneksi.eksekusiQuery(query); // Eksekusi query
            //
            if (temp.Rows.Count > 0) {
                cek = true;
            }

            return cek;
        }

        //Method untuk menampilkan data, menambah data, mengubah data, dan menghapus data
        public int simpanData()
        {
            int result = -1;

            //Untuk menambah data pada tabel jurusan
            query = "INSERT INTO jurusan VALUES ('" + kode_jurusan + "', '" + nama_jurusan + "')";

            try //Try digunakan untuk menangani eksekusi query
            {
                result = koneksi.eksekusiNonQuey(query); //Memanggil method eksekusiNonQuey pada kelas KoneksiCls
                if (result < 0) // Jika result kurang dari 0 maka akan muncul pesan "Data gagal disimpan"
                {
                    throw new Exception("Data gagal disimpan"); //Mengeluarkan pesan error
                }
            }catch (Exception e) { }

            return result;
        }

        public int ubahData(string kode)
        {
            int result = -1;

            //Untuk mengubah data pada tabel jurusan
            query = "UPDATE jurusan SET nama_jurusan = '" + nama_jurusan + "' WHERE kode_jurusan = '" + kode + "'";

            try //
            {
                result = koneksi.eksekusiNonQuey(query); //Memanggil method eksekusiNonQuey pada kelas KoneksiCls
                if (result < 0)
                {
                    throw new Exception("Data gagal diubah");
                }
            }catch (Exception e) { }

            return result;
        }

        public int hapusData(string kode)
        {
            int result = -1;

            //Untuk menghapus data pada tabel jurusan
            query = "DELETE FROM jurusan WHERE kode_jurusan = '" + kode + "'";

            try //
            {
                result = koneksi.eksekusiNonQuey(query); //Memanggil method eksekusiNonQuey pada kelas KoneksiCls
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus");
                }
            }
            catch (Exception e) { }

            return result;
        }

        public DataTable cariDgNama(string nama)
        {
            query = "SELECT * FROM jurusan WHERE nama_jurusan like '" + nama + "%'";

            return koneksi.eksekusiQuery(query);
        }

        public DataTable cariDgKode(string kode)
        {
            query = "SELECT * FROM jurusan WHERE kode_jurusan like '" + kode + "%'";

            return koneksi.eksekusiQuery(query);
        }

        // Ambil kode dengan nama jurusan sebagai parameter pada database
        //public string ambilKodeDgNama(string nama)
        //{
        //    string kode = "";
        //    query = "SELECT kode_jurusan FROM jurusan WHERE nama_jurusan = '" + nama + "'";
        //    temp = koneksi.eksekusiQuery(query);
        //    if (temp.Rows.Count > 0)
        //    {
        //        foreach (DataRow data in temp.Rows)
        //        {
        //            kode = data[0].ToString();
        //        }
        //    }
        //    return kode;
        //}

        public DataTable tampilkanSemua()
        {
            query = "SELECT * FROM jurusan";

            return koneksi.eksekusiQuery(query);
        }

        public string buatKode()
        {
            string kode = "";
            int result = -1;
            query = "SELECT IFNULL(MAX(kode_jurusan),0)+1 AS kode FROM jurusan";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach(DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    kode = "0" + result.ToString();
                }else if (result >= 10 && result < 100)
                {
                    kode = result.ToString();
                }
            }
            return kode;
        }
    }
}

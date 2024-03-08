using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema.model
{

    using konfigurasi;
    using System.Collections;

    class ProdiCls
    {
        private string kode_prodi;
        private string nama_prodi;
        private string nama_jurusan;

        KoneksiCls koneksi;
        DataTable temp;
        string query;

        public ProdiCls()
        {
            kode_prodi = "";
            nama_prodi = "";
            nama_jurusan = "";
            koneksi = new KoneksiCls();
            temp = new DataTable();
            query = "";

        }

        public string Kode_prodi
        {
            set { kode_prodi = value; }
        }

        public string Nama_prodi
        {
            set { nama_prodi = value; }
        }
        public string Nama_jurusan
        {
            set { nama_jurusan = value; }
        }

        public bool apakahAda(string kode)
        {
            bool cek = false;
            query = "select * from prodi where kode_prodi='" + kode + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        
            public int simpanData()
            {
                int result = -1;
                string kodeJurusan = GetKodeJurusan(nama_jurusan);

            if (string.IsNullOrEmpty(kodeJurusan))
            {
                throw new Exception("Kode Jurusan not found for selected nama_jurusan.");
            }

            query = "INSERT INTO prodi (kode_prodi, nama_prodi, kode_jurusan) VALUES ('\" + _kode_prodi + \"', '\" + _nama_prodi + \"', '\" + kodeJurusan + \"')";

                try
                {
                    result = koneksi.eksekusiNonQuey(query);
                if (result < 0)
                    {
                        throw new Exception("Gagal Menyimpan Data");
                    }
                }
                catch (Exception e)
                {
                }
                return result;
            }

        private string GetKodeJurusan(string nama_jurusan)
        {
            string kodeJurusan = string.Empty;

            string query = "SELECT kode_jurusan FROM jurusan WHERE nama_jurusan = '" + nama_jurusan + "'";
            DataTable result = koneksi.eksekusiQuery(query);

            if (result.Rows.Count > 0)
            {
                kodeJurusan = result.Rows[0]["kode_jurusan"].ToString();
            }

            return kodeJurusan;
        }

        public int ubahData(string kode)
        {
            int result = -1;
            string kodeJurusan = GetKodeJurusan(nama_jurusan);
            query = "update prodi set nama_prodi='" + nama_prodi + "', nama_jurusan='" + nama_jurusan + "' where kode_prodi='" + kode + "'";
            try
            {
                result = koneksi.eksekusiNonQuey(query);
                if (result < 0)
                {
                    throw new Exception("Gagal Mengubah Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public int hapusData(string kode)
        {
            int result = -1;
            query = "delete from prodi where kode_prodi='" + kode + "'";
            try
            {
                result = koneksi.eksekusiNonQuey(query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menghapus Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public DataTable tampilkanSemua()
        {
            query = "select a.kode_prodi, a.nama_prodi, b.nama_jurusan from prodi a, jurusan b where a.kode_jurusan = b.kode_jurusan";
            return koneksi.eksekusiQuery(query);
        }

        public DataTable isicombo()
        {
            query = "SELECT nama_jurusan FROM jurusan";
            return koneksi.eksekusiQuery(query);
        }

        public string buatKode()
        {
            string kode = "";
            int result = -1;
            query = "SELECT IFNULL(MAX(kode_prodi),0)+1 AS kode FROM prodi";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    kode = "0" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    kode = result.ToString();
                }
            }
            return kode;
        }
        
        // Mencari dengan Nama Prodi, Nama Jurusan, dan Kode Prodi dengan JOIN
        public DataTable cariDgNama(string nama)
        {
            query = "SELECT a.kode_prodi, a.nama_prodi, b.nama_jurusan FROM prodi a JOIN jurusan b ON a.kode_jurusan = b.kode_jurusan WHERE a.nama_prodi LIKE '%" + nama + "%' OR b.nama_jurusan LIKE '%" + nama + "%' OR kode_prodi LIKE '%" + nama + "%'";
            return koneksi.eksekusiQuery(query);
        }
        

        //public string ambilKodeDgNama(string nama)
        //{
        //    string kode = "";
        //    query = "select kode_prodian from prodi where nama_prodi ='" + nama + "'";
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


    }
}

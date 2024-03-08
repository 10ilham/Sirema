using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema.konfigurasi
{
    internal class KoneksiCls : KonfigurasiCls
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        // Menghubungkan ke database
        string Link = "server=localhost;port=3306;database=sirema;uid=root;pwd=";
        public KoneksiCls()
        {
            con = new MySqlConnection(Link); //menghubungkan ke string link
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }catch(Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        void tutupKoneksi()
        {
            con.Close(); 
        }
        public override int eksekusiNonQuey(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = con; //menghubungkan koneksi
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }

        // Mengambil data dari database
        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                // membuka koneksi
                bukaKoneksi();
                cmd.Connection = con; //menghubungkan koneksi
                cmd.CommandText = query; //mengambil query
                adapter.SelectCommand = cmd; //mengambil data
                adapter.Fill(result); //mengisi data
            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }
    }
}

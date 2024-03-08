using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema.konfigurasi
{
    // Kelas ini digunakan untuk menyimpan konfigurasi yang digunakan oleh aplikasi
    abstract class KonfigurasiCls
    {
        //Method untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiNonQuey(string query);

        //Method untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);
    }
}

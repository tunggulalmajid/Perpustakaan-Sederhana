using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_Sederhana
{
    public class penyimpananBuku
    {
        private List<Buku> tempatBuku;
        public penyimpananBuku() 
        {
            tempatBuku = new List<Buku> ();
        }

        public void simpanBuku(Buku nama)
        {
            tempatBuku.Add(nama);
        }
         


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_Sederhana
{
    public class penyimpananBuku
    {
        Buku buku;
        private List<Buku> tempatBuku;
        public penyimpananBuku() 
        {
            tempatBuku = new List<Buku> ();
        }

        public void simpanBuku(Buku nama)
        {
            tempatBuku.Add(nama);
        }
        public void lihatBuku()
        {

            if (tempatBuku.Count > 0)
            {
                Console.WriteLine("Buku yang Tersimpan :");
                for (int i = 0; i < tempatBuku.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {tempatBuku[i]}");
                }
            }
            else
            {
                Console.WriteLine("tidak ada buku tersimpan");
            }
            
        }


    }
}

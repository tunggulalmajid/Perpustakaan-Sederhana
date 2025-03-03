using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_Sederhana
{
    public class Buku
    {
        public string Kategori { get; set; }
        public string Judul { get; set; }
        public int TahunTerbit { get; set; }
        public string NomorBuku { get; set; }

        public Buku(string kategori, string judul, int tahunTerbit, string nomorBuku)
        {
            Judul = judul;
            Kategori = kategori;
            TahunTerbit = tahunTerbit;
            NomorBuku = nomorBuku;
        }
        public void tambahBukuBerhasil()
        {
            Console.WriteLine(
                $"\nKategori Buku: {Kategori}\n" +
                $"Judul Buku: {Judul}\n" +
                $"Tahun Terbit : {TahunTerbit}\n" +
                $"Nomor Buku : {NomorBuku}\n\n" +
                $"Buku berhasil ditambahkan...");
        }

        public override string ToString()
        {
            return $"Kategori : {Kategori}, Judul Buku : {Judul}, Tahun terbit : {TahunTerbit}, Nomor Buku : {NomorBuku}  ";
        }

    }
}

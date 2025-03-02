using System.Timers;
using Perpustakaan_Sederhana;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        header();

        Console.WriteLine("Menu : ");
        Console.WriteLine("1. Tambahkan Buku");
        Console.WriteLine("2. List Buku");
        Console.WriteLine("3. Hapus Buku");
        Console.WriteLine("4. Keluar");
        garis(60);

        while (true)
        {
            try
            {
                Console.Write("Masukkan Opsi Yang Ingin Dipilih >> ");
                int pilihOpsi = Convert.ToInt32(Console.ReadLine());
                if (pilihOpsi == 1)
                {
                    tambahBuku();
                    break;
                }
                else if (pilihOpsi == 2)
                {
                    Console.WriteLine("haha");

                }
                else if (pilihOpsi == 3)
                {
                    Console.WriteLine("haha");

                }
                else if (pilihOpsi == 4)
                {
                    Console.WriteLine("haha");

                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.ReadLine();
    }
    static void garis(int n)
    {
        Console.WriteLine(new string('═', n));
    }
    static void header()
    {
        garis(60);
        Console.WriteLine("PERPUSTAKAAN SEDERHANA".PadLeft(40));
        garis(60);

    }
    static void tambahBuku()
    {
        Console.Clear();
        header();

        Console.Write("Masukkan Kategori Buku >> ");
        string kategori = Console.ReadLine();
        Console.Write("Masukkan Judul Buku >> ");
        string judulBuku = Console.ReadLine();
        Console.Write("Masukkan Tahun Terbit >> ");
        int tahunTerbit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan Nomor Buku >> ");
        string nomorBuku = Console.ReadLine();

        Console.Clear();
        header();
        Buku buku = new Buku(kategori,judulBuku,tahunTerbit,nomorBuku);
        buku.tambahBukuBerhasil();
        garis(60);
    }
}
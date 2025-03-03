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
                    LihatBuku();
                    break;

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
        penyimpananBuku simpan = new penyimpananBuku();
        string kategori;
        string judulBuku;
        int tahunTerbit;
        string nomorBuku;

        Console.Clear();
        header();
       
        Console.Write("Masukkan Kategori Buku >> ");
        kategori = Console.ReadLine();
            
        Console.Write("Masukkan Judul Buku >> ");
        judulBuku = Console.ReadLine();
            
        while (true)
        {
            try
            {
                Console.Write("Masukkan Tahun Terbit >> ");
                tahunTerbit = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception e) { Console.WriteLine($"Error : {e.Message}"); }
        }

       
        Console.Write("Masukkan Nomor Buku >> ");
        nomorBuku = Console.ReadLine();
        
        Console.Clear();
        header();
        Buku buku = new Buku(kategori,judulBuku,tahunTerbit,nomorBuku);
        simpan.simpanBuku(buku);
        buku.tambahBukuBerhasil();
        garis(60);
        simpan.lihatBuku();
        //LihatBuku();

    }
    static void LihatBuku()
    {
        penyimpananBuku simpan = new penyimpananBuku();

        Console.Clear();
        header();
        simpan.lihatBuku();
    }
}
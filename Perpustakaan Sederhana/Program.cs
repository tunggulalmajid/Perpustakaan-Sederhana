using System.Security.Cryptography.X509Certificates;
using System.Timers;
using Perpustakaan_Sederhana;

internal class Program
{
    public static penyimpananBuku simpan = new penyimpananBuku();
    public static void Main(string[] args)
    {
        
        awalProgram();
        Console.ReadLine();
    }
    static void enter()
    {
        Console.Write("Tekan enter untuk melanjutkan >> ");
        Console.ReadLine() ;
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
    static void awalProgram()
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
    }
    static void tambahBuku()
    {
        
        //penyimpananBuku simpan = new penyimpananBuku();
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
        enter();
        awalProgram();

    }
    static void LihatBuku()
    {
        Console.Clear();
        header();
        simpan.lihatBuku();
        garis(60);
        enter();
        awalProgram();
    }
}
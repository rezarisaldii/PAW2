using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace PAW2
{
    public class Kasir
    {
        public void KasieCafe()
        {
            {
                Console.WriteLine("+=========================================+");
                Console.WriteLine("     Program Kasir Cafe Sederhana          ");
                Console.WriteLine("             Cafe Ganteng                  ");
                Console.WriteLine("+=========================================+");
                Console.Write("\n");
                Console.WriteLine("  Silakan Memilih Item Dari Menu  ");
                Console.Write("\n");
                //menampilkan menu makanan
                Console.WriteLine("=============Makanan=============");
                Console.Write("\n");
                Console.WriteLine("1. Magelangan            : Rp. 10000");
                Console.WriteLine("2. Mie Goreng            : Rp.  8000");
                Console.WriteLine("3. Roti Bakar pisang     : Rp. 10000");
                Console.WriteLine("4. Ayam Goreng           : Rp.  5000");
                Console.Write("\n");
                //menampilkan menu minuman 
                Console.WriteLine("=============Minuman=============");
                Console.WriteLine("1. Thai Tea              : Rp. 10000");
                Console.WriteLine("2. Jus                   : Rp.  6000");
                Console.WriteLine("3. Vanilla Latte         : Rp. 40000");
                Console.WriteLine("4. Kopi Mocha            : Rp. 45000");

                int jumlah;
                //Looping dengan memasukkan jumlah barang menggunakan kondisi doo while
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang: ");
                    jumlah = int.Parse(Console.ReadLine());

                } while (jumlah <= 0 || jumlah > 100);

                //mendeklarasikan atau mendefinisikan variabel data 
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;


                //menampilkan masukan nama pelanggan
                Console.WriteLine("============================");
                Console.Write("Masukkan nama pelanggan : ");
                //deklarasi variabel data string
                string namapl = Console.ReadLine();

                //Looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //menampilkan input nama barang
                        Console.WriteLine("===============================");
                        Console.Write("Masukkan nama barang ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //User harus menginput nama barang diatas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length >= 20);

                    do
                    {
                        //menampilkan input harga
                        Console.Write("Masukkan Harga Barang ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                        //user harus menginput harga barang min 5000 sampai 1000000
                    }
                    while (harga[i] <= 4000 || harga[i] >= 1000000);
                }
                //menampilkan barang dan harga yang sudah di pilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("=============================");
                Console.WriteLine("Daftar Barang Yang Di Pilih");
                Console.WriteLine("=============================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);

                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //menampilkan total harga
                Console.WriteLine("===============================");
                Console.WriteLine("Total Harga : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;

                    //kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uangmu Tidak Cukup !");

                    }
                    //kondisi dimana input uang yang dibayarkan lebih
                    else //menampilkan uang kembalian
                    {
                        Console.WriteLine("Uang kembalian anda : Rp"+ kembalian);
                    }
                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", namapl.ToString());
                Console.Write("\n");
                //menampilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal Transaksi:"+ DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi :"+ DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("=====================================");
                Console.WriteLine("Nama Kasir : Reza Risaldi");
                Console.WriteLine("Terima kasih");
                Console.WriteLine("=====================================");

                //mencetak nota dengan menggunakan streamwritter
                using (StreamWriter sw = new StreamWriter(@"C:\Nota.txt")) //lokasi tempat file nota dicetak
                {
                    sw.WriteLine("+=====================================================================+");
                    sw.WriteLine("+======================= NOTA PEMBAYARAN =============================+");
                    sw.WriteLine("+=====================================================================+");
                    sw.WriteLine("                     Nama Barang yang dibeli                           ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                    }
                    sw.WriteLine("+======================================================================+");
                    sw.WriteLine("Total harga          : Rp" + total);
                    sw.WriteLine("Tunai                : Rp" + bayar);
                    sw.WriteLine("Kembalian            : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //menampilkan nama pelanggan 
                    sw.WriteLine("Nama pelanggan: {0}", namapl.ToString());
                    //menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal Transaksi :"+ DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi :" + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("+=======================================================+");
                    sw.WriteLine("Nama Kasir : Reza Risaldi ");
                    sw.WriteLine("      Terima Kasih      ");
                    sw.WriteLine("+=======================================================+");
                    Console.Write("\n");
                    Console.WriteLine("Nota Telah Di Print");

                }
                Console.WriteLine();
                Console.Write("Tekan 'ENTER' Untuk Keluar....");
                Console.ReadLine();
            }
        }
            static void Main(string[] args)
            {
                //memanggil kelas Kasircafe
                Kasir KasirC = new Kasir();
                KasirC.KasieCafe();
            }
    }
}

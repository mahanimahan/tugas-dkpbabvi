using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBabVI_Kel58
{
    class Program
    {
        public void handle()
        {
            Main(null);
        }
        public static void mainprog()
        {
            Process proses = new Process();
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Selamat Datang di Toko Baju SUPREME!!");
            Console.WriteLine("Cepat Belanja Terus Keluar!");
            Console.WriteLine("Hari ini spesial: 1 customer 1 item");
            Console.WriteLine("Ga boleh beli lebih dari 1 item");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Silakan pilih: ");
            Console.WriteLine("\nBlouse \tBatik");
            Console.WriteLine("\nKaos   \tJas\n");
            proses.Hargabaju(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            IO io = new IO();
            string response = "";
            do {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("M.Sayyidus Shaleh Y. 21120117130058");
                Console.WriteLine("Mahani Halwa 21120117140016");
                Console.WriteLine("Kelompok 58");
                Console.WriteLine("Shift 4");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ");
                Console.WriteLine("\n1\tBeli Baju");
                Console.WriteLine("q\tQuit");
                Console.Write("\nPilih 1 atau q: ");
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        mainprog();
                        break;
                    case "q":
                        io.exit();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
            while (response!="q");
        }
    }
}

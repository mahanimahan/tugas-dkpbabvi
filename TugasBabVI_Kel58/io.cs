using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBabVI_Kel58
{
    class IO
    {
        Program main = new Program();
        string namabaju;
        int jumlahbaju;
        public IO()
            {
            Console.WriteLine("IO Class activated");
            }
        
        public string inputnama(string nmbaju)
        {
            namabaju = Console.ReadLine();
            nmbaju = namabaju;
            return nmbaju;
        }
        public int inputjumlah(int jmlbaju)
        {
            jumlahbaju = int.Parse(Console.ReadLine());
            jmlbaju = jumlahbaju;
            return jmlbaju;
        }
        public void exit()
        {
            Console.Write("Terimakasih telah membeli produk kami! Press enter key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void salah()
        {
            Console.Write("Invalid input detected. Press any key to continue....");
            Console.ReadKey();
            main.handle();
        }
    }
}

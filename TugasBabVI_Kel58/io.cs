using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBabVI_Kel58
{
    public class IO
    {
        Program main = new Program();
        string namabaju;
        int jumlahbaju;
        public IO()
            {
            Console.WriteLine("IO Class activated");
            }
        
        public void setNama(string nmbaju){this.namabaju = nmbaju;}
        public void setBaju(int jmlbaju){this.jumlahbaju = jmlbaju;}
        public string getNama() { return namabaju; }
        public int getBaju() { return jumlahbaju; }
        public void exit()
        {
            Console.Write("\nTerimakasih telah membeli produk kami! Press enter key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void salah()
        {
            Console.Write("\nInvalid input detected. Press any key to continue....");
            Console.ReadKey();
            main.handle();
        }
        public void balek()
        {
            Console.Write("\nMau (1)Belanja lagi, atau (2)Exit: ");
            string p = Console.ReadLine();
                switch(p)
                {
                    case "1":main.mainprog();break;
                    case "2":exit();break;
                    default:salah();break;
                }
            
        }
    }
}

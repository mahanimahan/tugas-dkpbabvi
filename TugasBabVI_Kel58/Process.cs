using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBabVI_Kel58
{
    class Process
    {
        IO io = new IO();
        int hargabaju;
        int total;
        int blouse = 90;
        int batik = 80;
        int kaos = 30;
        int jas = 40;
        public Process()
        {
            Console.WriteLine("Process Class activated");
        }
        public void notablouse(){Console.WriteLine("Total belanja anda: USD " + blouse );}
        public void notabatik(){Console.WriteLine("Total belanja anda: USD " + batik);}
        public void notakaos(){Console.WriteLine("Total belanja anda: USD " + kaos);}
        public void notajas(){Console.WriteLine("Total belanja anda: USD " + jas);}
        public string Hargabaju(string inputnama)
        {
            io.inputnama(inputnama);
            switch(inputnama)
            {
                case "blouse":
                    notablouse();
                    break;
                case "batik":
                    notabatik();
                    break;
                case "kaos":
                    notakaos();
                    break;
                case "jas":
                    notajas();
                    break;
                default:
                    io.salah();
                    break;
            }

            return null;
        }
    }
}

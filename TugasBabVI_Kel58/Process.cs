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
        int blouse = 90, jmlbls;
        int batik = 80, jmlbtk;
        int kaos = 30, jmlkaos;
        int jas = 40, jmljas;
        public Process()
        {
            Console.WriteLine("Process Class activated");
        }

        public void notablouse()
        {
            Console.Write("\nJumlah blouse yang anda inginkan: ");
            try
            {
                jmlbls = int.Parse(Console.ReadLine()); io.setBaju(jmlbls);
                blouse = blouse * io.getBaju();
            }
            catch (Exception e) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: USD " + blouse );
        }
        public void notabatik()
        {
            Console.Write("\nJumlah batik yang anda inginkan: ");
            try
            {
                jmlbtk = int.Parse(Console.ReadLine()); io.setBaju(jmlbtk);
                batik = batik * io.getBaju();
            }
            catch (Exception e) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: USD " + batik);
        }
        public void notakaos()
        {
            Console.Write("\nJumlah kaos yang anda inginkan: ");
            try
            {
                jmlkaos = int.Parse(Console.ReadLine()); io.setBaju(jmlkaos);
                kaos = kaos * io.getBaju();
            }
            catch (Exception e) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: USD " + kaos);
        }
        public void notajas()
        {
            Console.Write("\nJumlah jas yang anda inginkan: ");
            try
            {
                jmljas = int.Parse(Console.ReadLine()); io.setBaju(jmljas);
                jas = jas * io.getBaju();
            }
            catch (Exception e) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: USD " + jas);
        }
        public string Hargabaju(string inputnama)
        {
            io.setNama(inputnama);
            switch(io.getNama())
            {
                case "blouse":
                    notablouse();
                    io.balek();
                    break;
                case "batik":
                    notabatik();
                    io.balek();
                    break;
                case "kaos":
                    notakaos();
                    io.balek();
                    break;
                case "jas":
                    notajas();
                    io.balek();
                    break;
                default:
                    io.salah();
                    io.exit();
                    break;
            }

            return null;
        }
    }
}

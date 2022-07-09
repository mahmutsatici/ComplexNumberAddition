using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmasik_Sayi_Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Komplex n = new Komplex(3,2);
            Komplex m = new Komplex(3,2);
            n.yazdir(m, n);
            Console.ReadLine();
        }
    }
    class Komplex
    {
        public int sanalkisim { get; set; }
        public int gercekkisim { get; set; }

        public Komplex(int _gercekkisim, int _sanalkisim)
        {
            this.sanalkisim = _sanalkisim;
            this.gercekkisim = _gercekkisim;
        }
        public static string operator +(Komplex a, Komplex b)
        {
            int sanaltoplam = a.sanalkisim + b.sanalkisim;
            int gercektoplam = a.gercekkisim + b.gercekkisim;
            return sanaltoplam + " + (" + gercektoplam + "i)";

        }
        public static bool operator ==(Komplex a, Komplex b)
        {
            if (a.gercekkisim==b.gercekkisim && a.sanalkisim==b.sanalkisim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Komplex a, Komplex b)
        {
            if (a.gercekkisim != b.gercekkisim && a.sanalkisim != b.sanalkisim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void yazdir(Komplex a,Komplex b)
        {
            if (a==b)
            {
                Console.WriteLine("Komplex sayılar eşittir");
            }
            else
            {
                Console.WriteLine("Komplex sayılar eşit değildir");
            }
            Console.WriteLine("Komplex sayıların toplamı: "+(a+b));
        }
    }
}

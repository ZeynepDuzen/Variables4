using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam, carpim, bolum, fark;
            s1 = 10;
            s2 = 2;
            toplam = s1 + s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            fark = s1 - s2;

            Console.WriteLine("*** Aritmetik İslemler ***");
            Console.WriteLine();
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Bölüm : " + bolum);
            Console.WriteLine("Çarpım : " + carpim);
            Console.WriteLine("Fark : " + fark);
            Console.WriteLine();
            Console.WriteLine("*** Aritmetik İslemler ***");

            Console.Read();
        }
    }
}

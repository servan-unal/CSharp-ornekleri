using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi= 3.14;

            double alan, çevre, yaricap;

            string yaricapGir;

            Console.WriteLine("Dairenin Yaricapini Gir");
            yaricapGir = Console.ReadLine();
            yaricap = Convert.ToDouble(yaricapGir);
            çevre = 2 * pi * yaricap;
            alan = pi * Math.Pow(yaricap, 2);
            Console.WriteLine("Dairenin alanı {0}", alan);
            Console.WriteLine("Dairenin çevresi {0}", çevre);
            Console.ReadKey();

            /*
             *const ile pi tanımladım.Sınıf içinde olduğu için sadece maine tanımlanmış oldu
             *yarıcap girmesini istedim sonra yarıcap ı double a cevirip tanımlanmış yaricap a attım
             *çevre ve alan hesaplaması yapıp ekrana yazdırdım son olarak readkey diyerek ekranda tuttum. */
        }
    }
}

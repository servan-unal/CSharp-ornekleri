using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aylar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ila 12 arasında bir sayı giriniz");
            byte ay = Convert.ToByte(Console.ReadLine());

            if (ay == 1)
            {
                Console.WriteLine("Ocak");
            }
            else if (ay == 2)
            {
                Console.WriteLine("Şubat");
            }
            else if(ay == 3)
            {
                Console.WriteLine("Mart");
            }
            else if(ay == 4)
            {
                Console.WriteLine("Nisan");
            }
            else if(ay == 5)
            {
                Console.WriteLine("Nisan");
            }
            else if(ay == 6)
            {
                Console.WriteLine("Mayıs");
            }
            else if(ay == 7)
            {
                Console.WriteLine("Haziran");
            }
            else if(ay == 8)
            {
                Console.WriteLine("Temmuz");
            }
            else if(ay == 9)
            {
                Console.WriteLine("Ağustos");
            }
            else if(ay == 10)
            {
                Console.WriteLine("Eylül");
            }
            else if(ay == 11)
            {
                Console.WriteLine("Kasım");
            }
            else
            {
                Console.WriteLine("Aralık");
            }
            Console.ReadKey();
        }
    }
}

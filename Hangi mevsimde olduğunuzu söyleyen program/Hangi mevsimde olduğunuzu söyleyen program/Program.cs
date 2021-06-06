using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangi_mevsimde_olduğunuzu_söyleyen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi aydasınız, lütfen yazınız");

            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("İlkbahar Mevsimini Yaşıyorsunuz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Yaz Mevsimini Yaşıyorsunuz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Sonbahar Mevsimini Yaşıyorsunuz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Kış Mevsimini Yaşıyorsunuz");
                    break;
                default:
                    Console.WriteLine("Yanlış sayi girdiniz");
                    break;


                    Console.ReadLine();


            }
        }
    }
}

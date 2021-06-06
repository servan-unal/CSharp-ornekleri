using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi , sonuc;
            Console.Write("Bir sayi giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi % 2;
            if(sonuc==0)
            {
                Console.WriteLine("Girilen sayi tek sayidir");
            }
            else
            {
                Console.WriteLine("Girilen sayi tek sayidir");
            }
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyunununa Hoş Geldiniz\n");
            Random rnd = new Random();
            byte baslangic = 0;
            byte bitis = 0;
            byte zorlukseviyesi = 0;
            byte kalanhak = 0;
            int sayi2 = 0;
            do
            {
                Console.Write("1-3 Arası Zorluk Seviyesi Seçiniz:");
                zorlukseviyesi = byte.Parse(Console.ReadLine());

            } while (zorlukseviyesi != 1 && zorlukseviyesi != 2 && zorlukseviyesi != 3);

            switch (zorlukseviyesi)
            {
                case 1:
                    baslangic = 1;
                    bitis = 10;
                    Console.WriteLine("1. Seviye Zorluk Seçtiniz");
                    kalanhak = 6;
                    sayi2 = rnd.Next(baslangic,bitis);
                    break;
                case 2:
                    baslangic = 1;
                    bitis = 25;
                    Console.WriteLine("2. Seviye Zorluk Seçtiniz");
                    kalanhak = 4;
                    sayi2 = rnd.Next(baslangic, bitis);
                    break;
                case 3:
                    baslangic = 1;
                    bitis = 50;
                    Console.WriteLine("3. Seviye Zorluk Seçtiniz");
                    kalanhak = 2;
                    sayi2 = rnd.Next(baslangic, bitis);
                    break;
            }

            for (; ; )
            {
                Console.WriteLine("Kalan hakkınız:" + kalanhak);
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == sayi2)
                {
                    Console.WriteLine("Tebrikler");
                }
                if (kalanhak <= 1)
                {
                    Console.WriteLine("Deneme Hakkınız Bitmiştir.");
                    break;
                }
                kalanhak--;
            }
        }
    }

}

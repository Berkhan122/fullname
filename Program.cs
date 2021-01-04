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
        Baslangic:
            Console.WriteLine("Sayı Tahmin Oyunununa Hoş Geldiniz\n");
        Hata:
            Console.Write("1-3 Arası Zorluk Seviyesi Seçiniz:");
            int zorlukseviyesi = int.Parse(Console.ReadLine());
            if (zorlukseviyesi > 3)
            {
                Console.WriteLine("Lütfen 1-3 arası zorluk seviyesi giriniz");
                goto Hata;
            }
            int kalanhak = 0;
            Random rnd = new Random();

            switch (zorlukseviyesi)
            {
                case 1:
                    kalanhak = 6;
                    Console.WriteLine("1. Seviye Zorluk Seçtiniz");
                    int sayi1 = rnd.Next(1, 10);
                    for (; ; )
                    {
                        Console.WriteLine("Kalan hakkınız:" + kalanhak);
                        Console.WriteLine("Bir sayı giriniz:");
                        int sayi = int.Parse(Console.ReadLine());
                        if (sayi == sayi1)
                        {
                            Console.WriteLine("Tebrikler");
                            goto Baslangic;
                        }
                        if (kalanhak <= 1)
                        {
                            Console.WriteLine("Deneme Hakkınız Bitmiştir.");
                            goto Baslangic;
                        }
                        kalanhak--;
                    }

                case 2:
                    kalanhak = 4;
                    Console.WriteLine("2. Seviye Zorluk Seçtiniz");

                    int sayi2 = rnd.Next(1, 25);
                    for (; ; )
                    {
                        Console.WriteLine("Kalan hakkınız:" + kalanhak);
                        Console.WriteLine("Bir sayı giriniz:");
                        int sayi = int.Parse(Console.ReadLine());
                        if (sayi == sayi2)
                        {
                            Console.WriteLine("Tebrikler");
                            goto Baslangic;
                        }
                        if (kalanhak <= 1)
                        {
                            Console.WriteLine("Deneme Hakkınız Bitmiştir.");
                            goto Baslangic;
                        }
                        kalanhak--;
                    }

                case 3:
                    kalanhak = 2;
                    Console.WriteLine("3. Seviye Zorluk Seçtiniz");

                    int sayi3 = rnd.Next(1, 50);
                    for (; ; )
                    {
                        Console.WriteLine("Kalan hakkınız:" + kalanhak);
                        Console.WriteLine("Bir sayı giriniz:");
                        int sayi = int.Parse(Console.ReadLine());
                        if (sayi == sayi3)
                        {
                            Console.WriteLine("Tebrikler");
                            goto Baslangic;
                        }
                        if (kalanhak <= 1)
                        {
                            Console.WriteLine("Deneme Hakkınız Bitmiştir.");
                            goto Baslangic;
                        }
                        kalanhak--;
                    }
            }
        }
    }

}


using System;
using System.Collections;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İkinci Uygulamaya Hoşgeldiniz...");
            Console.WriteLine("Sizden 20 adet sayı girmeniz beklenmektedir.Negatif ve nümerik olmayan sayılar kabul edilmemektedir.");
            ArrayList liste = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                liste.Add(takeNumber());
            }
            liste.Sort();
            int[] minSayilar = new int[3];
            int[] maxSayilar = new int[3];

            double minSayilarToplam = 0;
            double maxSayilarToplam = 0;
            double minSayilarOrtalama = 0;
            double maxSayilarOrtalama = 0;
            double ortalamaToplam = 0;

            for (int i = 0; i < 3; i++)
            {
                minSayilar[i] = Convert.ToInt32(liste[i]);
                minSayilarToplam += Convert.ToInt32(liste[i]);

                maxSayilar[i] = Convert.ToInt32(liste[19 - i]);
                maxSayilarToplam += Convert.ToInt32(liste[19 - i]);
            }
            minSayilarOrtalama = minSayilarToplam / minSayilar.Length;
            maxSayilarOrtalama = maxSayilarToplam / maxSayilar.Length;
            ortalamaToplam = minSayilarOrtalama + maxSayilarToplam;

            Console.WriteLine("\nMinimum sayıların ortalamaları {0} ve maximum sayıların ortalaması {1}, ayrıca bu ortalamaların toplamı {2}'dir.", minSayilarOrtalama, maxSayilarOrtalama, ortalamaToplam);






        }//main end
        public static int takeNumber()
        {
            int number;
            string numberString = Console.ReadLine();
            try
            {
                number = int.Parse(numberString);
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen nümerik bir sayı giriniz.");
                number = takeNumber();
            }
            if (number < 0)
            {
                Console.WriteLine("Lütfen negatif olmayan bir sayı giriniz.");
                takeNumber();
            }
            return number;

        }//takeNumber end
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
namespace app1
{
    class Program
    {
        public static void Main(string[] args)
        {



            Console.WriteLine("Birinci Uygulamaya Hoşgeldiniz...");
            Console.WriteLine("Sizden 20 adet pozitif sayı girmeniz beklenmektedir.Negatif ve nümerik olmayan sayılar kabul edilmemektedir.");
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                int number = takeNumber();
                if (asalMi(number))
                {
                    asalSayilar.Add(number);
                }
                else
                {
                    asalOlmayanSayilar.Add(number);
                }
            }
            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();
            Console.WriteLine("\nAsal Sayılar");

            double asalToplam = 0;
            double asalOlmayanToplam = 0;
            double asalOrtalama = 0;
            double asalOlmayanOrtalama = 0;

            foreach (int i in asalSayilar)
            {
                Console.Write(i + " ");
                asalToplam += i;
            }
            Console.WriteLine("\nAsal Olmayan Sayılar");
            foreach (int i in asalOlmayanSayilar)
            {
                Console.Write(i + " ");
                asalOlmayanToplam += i;
            }
            int asalCount = asalSayilar.Count;
            int asalOlmayanCount = asalOlmayanSayilar.Count;
            Console.WriteLine("\nGirdiğiniz rakamların {0} tanesi asal, {1} tanesi asal değildir.", asalCount, asalOlmayanCount);

            asalOrtalama = asalToplam/(double)asalCount;
            asalOlmayanOrtalama=asalOlmayanToplam/(double)asalOlmayanCount;
            Console.WriteLine("Asal sayıların ortalaması {0} ve asal olmayan sayıların ortalaması {1}",asalOrtalama,asalOlmayanOrtalama);


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

        public static Boolean asalMi(int sayi)
        {
            for (int i = 2;i<(sayi);i++ ){
                if(sayi%i==0){
                    return false;
                }
            }
            return true;
        }
    }
}

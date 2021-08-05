using System;
using System.Linq;
using System.Collections;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçüncü uygulamaya Hoşgeldiniz.");
            Console.WriteLine("Lütfen bir cümle giriniz.");

            string[] cumle = Console.ReadLine().Split(" ");
            char[] sesliHarfler = {'a','e','ı','i','o','ö','u','ü'};
            ArrayList liste = new ArrayList();
            foreach(string s in cumle){
                foreach (char c in s ){
                    if (sesliHarfler.Contains(c)){
                        liste.Add(c);
                    }
                }
            }
            liste.Sort();
            char[] sesliHarflerArrayi = new char[liste.Count];
            for(int i =0;i<liste.Count;i++){
                sesliHarflerArrayi[i]=Convert.ToChar(liste[i]);
            }

            foreach(char ch in sesliHarflerArrayi){
                Console.WriteLine(ch);
            }
            

        }
    }
}

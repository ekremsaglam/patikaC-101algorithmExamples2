using System;

namespace app1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Birinci Uygulamaya Hoşgeldiniz...");
            Console.WriteLine("Sizden 20 adet pozitif sayı girmeniz beklenmektedir.Negatif ve nümerik olmayan sayılar kabul edilmemektedir.");
            for(int i=0;i<20;i++){
                takeNumber();
            }       
            
        }
        public static int takeNumber(){
            int number;
            string numberString = Console.ReadLine();
            try
            {
                number = int.Parse(numberString]);
            }
            catch (Exception){
                Console.WriteLine("Lütfen nümerik bir sayı giriniz.");
                number = takeNumber();
            }
            if(number<0){
                Console.WriteLine("Lütfen negatif olmayan bir sayı giriniz.");
                takeNumber();
            }
            return number;

        }
    }
}

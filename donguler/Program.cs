using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "phayton" , "java" , "c#", "css","html"};

            foreach (string kurs in kurslar) 
            {
                Console.WriteLine( kurs);
            }

            //for (int i = 0; i < kurslar.Length; i++)
               
            //{
            //    Console.WriteLine(kurslar[i]);
                
            //}
            //Console.WriteLine("sayfasonu");
        }
    }
}

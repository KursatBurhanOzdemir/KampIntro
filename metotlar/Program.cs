using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            product urun1 = new product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            product urun2 = new product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "diyarbakır karpuzu";

            product[] urunler = new product[] {urun1,urun2 };

            foreach (product x in urunler) 
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("----------------metotlar--------------------");

            sepetmanager sepetmanager = new sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
          


                
        }  
    }
    
    
}

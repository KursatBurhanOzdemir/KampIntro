using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Jale";
            musteri1.Soyadi = "Yale";
            musteri1.Ulke = "ukrayna";
            musteri1.Tel = 05892342793;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ehmet";
            musteri2.Soyadi = "Bodur";
            musteri2.Ulke = "Türkiye";
            musteri2.Tel = 05392598343;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Özlem";
            musteri3.Soyadi = "Çuhallı";
            musteri3.Ulke = "Türkiye";
            musteri3.Tel = 05237928362;
               

            Musteri[] musteriler = new Musteri[]
            {
               musteri1,musteri2,musteri3
            };


            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri3);
            musterimanager.Silme(musteri2);
            musterimanager.Listele(musteriler);
            

        }
    }
}
   

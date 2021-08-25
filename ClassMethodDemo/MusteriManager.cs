using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri Musteri)
        {
            Console.WriteLine(Musteri.Id + " " + Musteri.Adi + " " + Musteri.Soyadi+" " + Musteri.Ulke + " " + Musteri.Tel+" ---  Musteri Eklendi ---");

        }
        public void Silme(Musteri Musteri)
        {
            Console.WriteLine(Musteri.Id + " " + Musteri.Adi + " " + Musteri.Soyadi + " " + Musteri.Ulke + " " + Musteri.Tel + " ---  Musteri Silindi ---");
        }
        public void Listele (Musteri[] Musteri)
        {
            foreach (var musteriler in Musteri)
            {
                Console.WriteLine(musteriler.Id + " " + musteriler.Adi + " " + musteriler.Soyadi + " " + musteriler.Ulke + " " + musteriler.Tel);
            }
            
        }

    }
}

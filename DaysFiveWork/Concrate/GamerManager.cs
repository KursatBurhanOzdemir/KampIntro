using DaysFiveWork.Abstract;
using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Concrate
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }

        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
           this.verificationService = verificationService;
        }

        public void Add(Gamer gamer)
        {
            if (verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.CustomerName + gamer.CustomerSurname + "isimli oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("bilgileriniz uyuşmuyor yeniden deneyiniz.");
            }
        }

      

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.CustomerName + gamer.CustomerSurname + "isimli oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.CustomerName + gamer.CustomerSurname + "isimli oyuncu güncellendi");
        }
    }
}

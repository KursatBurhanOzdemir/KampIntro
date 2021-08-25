﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void Basvuruyap(IKrediManager krediManager, IloggerService loggerService)
        {
            //başvuru bilgilerini değerlendirme
            //
            //sonra kredi hesaplama yapcaz 
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

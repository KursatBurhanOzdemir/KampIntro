using DaysFiveWork.Abstract;
using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Concrate
{
    class GameSaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaing campaing)
        {
            double calculatePrice = game.Price - (game.Price * (campaing.Discount / 100));
            Console.WriteLine(game.GameName+ "oyunu" + gamer.CustomerName + " " +gamer.CustomerSurname +" kişisine satıldı" );
            Console.WriteLine("kapmanyanın indirim fiyatı : " + (game.Price * (campaing.Discount / 100)));
            Console.WriteLine("ödenen indirimli tutar: "+calculatePrice );
        }
    }
}

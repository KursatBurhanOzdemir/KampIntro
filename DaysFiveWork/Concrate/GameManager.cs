using DaysFiveWork.Abstract;
using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Concrate
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +"Adlı Oyun Eklendi "+ "Fiyatı :" +game.Price + " stok sayısı: "+ game.Stock);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyun silindi" );
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Adlı oyun Güncellendi" );
        }
    }
}

using DaysFiveWork.Concrate;
using DaysFiveWork.Entity;
using System;

namespace DaysFiveWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game
            {    
                GameName = "Assassin's Creed Valhalla",
                Stock = 5,
                Price = 250
            };
            Game game2 = new Game
            {
                GameName = "Call Of Duty Modern Warfare",
                Stock = 2,
                Price = 350
            };
            Game game3 = new Game
            {
                GameName = "God Of War",
                Stock = 6,
                Price = 300
            };

            
             Campaing campaign1 = new Campaing();
            campaign1.Name = "Yaz İndirimi";
            campaign1.Discount = 50;

            Campaing campaign2 = new Campaing();
            campaign2.Name = "Kış İndirimi";
            campaign2.Discount = 25;


            Gamer gamer1 = new Gamer
            {
                CustomerName = "Sıla ",
                CustomerSurname = "Çakır",
                NationaltyId = "12345678943",
                DateOfBirth = new DateTime(1924, 5, 12)
            };
            Gamer gamer2 = new Gamer
            {
                CustomerName = "Kürşat ",
                CustomerSurname = "Salar",
                NationaltyId= "10987654123",
                DateOfBirth = new DateTime(2000, 12, 20)
            };


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);

            Console.WriteLine("**********************");

           
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("-------------------------");


            gameManager.Add(game2);

            Console.WriteLine("------------------");

            
            CampaingManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("-----------------");

           
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);

            Console.WriteLine("-----------------");

            gameSaleManager.Sale(gamer2, game3, campaign2);
        }
    }
}

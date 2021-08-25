using DaysFiveWork.Abstract;
using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Concrate
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.Name+"kampanyası eklendi.");
            Console.WriteLine( "kampanya indirimi %"+campaing.Discount );
        }

      

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.Name + "kampanyası silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.Name+"kampanyası güncellendi");
            Console.WriteLine("güncel kampanya indirimi %"+campaing.Discount);

           
        }
        
        

    }
}

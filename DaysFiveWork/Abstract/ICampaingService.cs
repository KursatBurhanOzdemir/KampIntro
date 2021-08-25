using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Abstract
{
    interface ICampaingService
    {
        void Add(Campaing campaing );
        void Delete(Campaing campaing); 
        void Update(Campaing campaing);
        
    }
}

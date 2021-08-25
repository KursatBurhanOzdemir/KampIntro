using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game, Campaing campaing);
    }
}

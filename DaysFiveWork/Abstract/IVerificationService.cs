using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Abstract
{
    interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}

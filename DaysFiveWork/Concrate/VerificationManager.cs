using DaysFiveWork.Abstract;
using DaysFiveWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaysFiveWork.Concrate
{
    class VerificationManager
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {


            if (gamer.NationaltyId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

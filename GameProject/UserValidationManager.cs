using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Engin"
                && gamer.LastName == "Demiroğ" && gamer.İdentityNumber == 12345)
            {
                return true; 
            }
            else
            {
                return true;
            }
        }
    }
}

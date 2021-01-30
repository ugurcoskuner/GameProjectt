using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1992 &&
               gamer.FirstName == "Uğur" && gamer.LastName == "Coşkuner"
               && gamer.Tc == "1")
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

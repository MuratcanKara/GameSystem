using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Abstract;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if ((gamer.Id == 1 && gamer.NickName == "zprotectivity"&& gamer.IdentityNumber == "5646847651464" && gamer.Age == "18" && gamer.DateOfBirth == "02.04.2003"))
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

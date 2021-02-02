using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Abstract;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}

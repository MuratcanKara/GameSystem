using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Abstract;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class GamerManager : IGamerService
    {

        private IUserValidationService _userValidation;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;
        }
        
        
        public void Add(Gamer gamer)
        {
            if (_userValidation.CheckIfRealGamer(gamer) ==true )
            {
                Console.WriteLine("Kimlik Kaydınız OLUŞTURULDU");
            }
            else
            {
                Console.WriteLine("Kimliginiz DOGRULANMADI");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kimlik Kaydınız SİLİNDİ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kimlik Kaydınız GÜNCELLENDİ");
        }
    }
}

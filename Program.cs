using System;
using GameSystem.Concrete;
using GameSystem.Entities;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer();
            gamer1.Age = "18";
            gamer1.Id = 1;
            gamer1.NickName = "zprotectivity";
            gamer1.IdentityNumber = "5646847651464";
            gamer1.DateOfBirth = "02.04.2003";
            gamerManager.Add(gamer1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Abstract;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class CampainManager : ICampainService
    {
        public void AddACampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Eklendi" + campaing.CampaingName + "-" + campaing.CampaingId);
        }

        public void DeleteACampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Kaldırıldı" + campaing.CampaingName + "-" + campaing.CampaingId);
        }

        public void UpdateACampaing(Campaing campaing)
        {
            Console.WriteLine("Kampanya Güncellendi" + campaing.CampaingName + "-" + campaing.CampaingId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Entities;

namespace GameSystem.Abstract
{
    public interface ICampainService
    {
        void AddACampaing(Campaing campaing);
        void UpdateACampaing(Campaing campaing);
        void DeleteACampaing(Campaing campaing);
    
    
    }
}

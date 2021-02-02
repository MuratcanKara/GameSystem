using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Entities;

namespace GameSystem.Abstract
{
    public interface ISaleService
    {
        void AddASale(Sale sale);
        void UpdateASale(Sale sale);
        void DeleteASale(Sale sale);





    }
}

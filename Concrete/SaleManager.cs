using System;
using System.Collections.Generic;
using System.Text;
using GameSystem.Abstract;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class SaleManager : ISaleService
    {
        public void AddASale(Sale sale)
        {
            Console.WriteLine("İndirim Eklendi" + sale.SaleName);
        }

        public void DeleteASale(Sale sale)
        {
            Console.WriteLine("İndirim Silindi" + sale.SaleName);
        }

        public void UpdateASale(Sale sale)
        {
            Console.WriteLine("İndirim Güncellendi" + sale.SaleName);
        }
    }
}

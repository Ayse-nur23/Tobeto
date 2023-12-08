using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameSellManager : ISellService
    {
        public void Sell(Game game, Customer customer, Campaign campaign = null)
        {
            Console.WriteLine("{0} Oyunu {1} tarafıdan  {2} TL'ye satın alındı.", game.GameName, customer.FirstName, game.UnitPrice);
        }
    }
}

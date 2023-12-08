using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaingSellManager : ISellService
    {
        public void Sell(Game game, Customer customer, Campaign campaign = null)
        {
            double price = game.UnitPrice - (game.UnitPrice * campaign.campaignDiscount / 100);
            Console.WriteLine("{0} Oyunu {1} tarafıdan kampanyalı fiyatı {2} TL'ye satın alındı.", game.GameName, customer.UserName, price);
        }
    }
}

using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface ISellService
    {
        void Sell(Game game, Customer customer, Campaign campaign = null);
    }
}

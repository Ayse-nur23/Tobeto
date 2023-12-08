using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaingManager : ICampaignService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Campaign added");
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Campaign deleted");
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Campaign updated");
        }
    }
}

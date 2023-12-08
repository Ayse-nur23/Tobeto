using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Campaign: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double campaignDiscount { get; set; }
    }
}

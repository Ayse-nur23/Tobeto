using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Game :IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Platforms { get; set; }
        public int FirstReleaseDate { get; set; }
        public double UnitPrice { get; set; }
    }
}

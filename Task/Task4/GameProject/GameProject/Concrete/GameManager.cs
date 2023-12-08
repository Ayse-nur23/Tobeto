using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game entity)
        {
            Console.WriteLine("Game adedd");
        }

        public void Delete(Game entity)
        {
             Console.WriteLine("Game deleted");
        }

        public void Update(Game entity)
        {
            Console.WriteLine("Game updated");
        }
    }
}

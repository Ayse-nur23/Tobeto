using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer= new Customer { Id = 1, FirstName = "Ayşenur", LastName = "Elmas", UserName = "ayse44", NationalityId = "12345678909",
                                                DateOfBirth = new DateTime(2000,08,01)};

            CustomerManager customerManager= new CustomerManager(new UserValidationService());
            customerManager.Add(customer);


            Game game = new Game { Id = 1, GameName = "Forza Horizon 4", Platforms = "Xbox One, Microsoft Windows, Xbox X ve S Serisi",
                                    FirstReleaseDate = 2018, UnitPrice = 29.99 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);


            Campaign campaign = new Campaign { Id = 1, Name = "Yeni Gelenlere Özel %10 indirim", campaignDiscount = 10 };
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaign);

            ISellService sellService = new GameSellManager();
            sellService = new CampaingSellManager();
            sellService.Sell(game, customer, campaign);

            

        }
    }
}
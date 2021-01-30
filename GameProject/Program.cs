using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.Tc = "1";
            gamer.FirstName = "Uğur";
            gamer.LastName = "Coşkuner";
            gamer.BirthYear = 1992;

           IGamerService gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Uptade(gamer);

            Console.WriteLine("----------------------------");


            Campaign campaign1 = new Campaign();
            {
                campaign1.Id = 1;
                campaign1.CampaingName = "Winter Sale";
                campaign1.RateOfDiscount = 22.5;
            }

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Cadd(campaign1);


            Game game = new Game();
            game.Id = 1;
            game.Name = "Fifa 2020";
            game.Platform = "Online";
            game.Price = 10;
            game.Rating = 8.1;

            IGamePurchaseService gamePurchaseService = new GamePurchaseManager();
            gamePurchaseService.Purchase(gamer,campaign1,game);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamePurchaseManager : IGamePurchaseService
    {
        public void Purchase(Gamer gamer, Campaign campaign, Game game)
        {
            Console.WriteLine(gamer.FirstName+ " " + game.Name + "oyununu " + campaign.CampaingName +"kampanya ile" + " başarıyla satın aldı");
        }
    }
}

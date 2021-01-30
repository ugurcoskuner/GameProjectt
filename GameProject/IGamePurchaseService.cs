using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamePurchaseService
    {
        void Purchase(Gamer gamer, Campaign campaign, Game game);
    }
}

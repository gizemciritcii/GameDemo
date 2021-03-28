using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entity;

namespace GameDemo.Abstract
{
    interface IGameSellService
    {

        void Sell(Game game, Gamer  gamer );
        void SellWithCampaign(Game game, Gamer gamer, campaign campaign);
    }
}

using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameSellManager : IGameSellService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("sevgili"+ gamer.LastName+gamer.FirstName+", almış olduğunuz "+game.GameName+" iyi günlerde kullanmanızı dileriz.  Oyun ücreti: "+game.GamePrice);
           
        }

        public void SellWithCampaign(Game game, Gamer gamer, campaign campaign)
        {
            Console.WriteLine("sevgili" + gamer.LastName + gamer.FirstName + ", almış olduğunuz " + game.GameName + " oyununu" +campaign.CamGameName +" kanpanya dahilinde " + game.GamePrice+"TL ödeyerek satın aldınız. İyi günler dileriz.");

        }
    }
}

using GameDemo.Concrete;
using GameDemo.Entity;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new campaign() {CamGameName="MTN2",CampaignId=1,CampaignDiscount="½20" });



            Gamer gamer1 = new Gamer();
            gamer1.Id = 2;
            gamer1.NationalityId =" 10838990626";
            gamer1.LastName = "ciritci";
            gamer1.FirstName = "gizem";
            // gamer1.BirthYear = 1998;


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer { BirthYear = new DateTime(1998, 01, 03),
                FirstName = "gizem",
                LastName = "ciritci",
                NationalityId = "10838990626",
                Id = 2
            });


            Console.WriteLine(gamerManager);

            Game game1 = new Game();
            game1.GameName = "Grand Theft Auto V";
            game1.GamePrice = 450;

            campaign campaign = new campaign();
            campaign.CamGameName = "black friday";


            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.Sell(game1,gamer1);

            
        }
    }
}

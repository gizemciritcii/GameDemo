using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(campaign campaign)
        {
            Console.WriteLine( campaign.CamGameName+ "kanpanya eklendi");
        }

        public void Delete(campaign campaig)
        {
            Console.WriteLine(  "kanpanya silindi");
        }

        public void Update(campaign campaig)
        {
            Console.WriteLine( "kanpanya güncellendi");
        }
    }
}

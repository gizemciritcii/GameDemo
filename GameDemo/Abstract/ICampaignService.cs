using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ICampaignService
    {


        void Add(campaign campaign);
        void Delete(campaign campaig );

        void Update(campaign campaig);
    }
}

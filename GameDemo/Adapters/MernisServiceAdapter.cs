using GameDemo.Abstract;
using GameDemo.Entity;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckifRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId),gamer.FirstName.ToUpper,gamer.LastName.ToUpper,
                gamer.BirthYear.Year);
        }
    }
}

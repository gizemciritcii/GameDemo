using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
 public  interface IUserCheckService
    {

        public bool CheckifRealPerson(Gamer gamer);
    }
}

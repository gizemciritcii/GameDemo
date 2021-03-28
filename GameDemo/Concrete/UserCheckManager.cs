using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
 public   class UserCheckManager:IUserCheckService
    {
        public bool CheckifRealPerson(Gamer gamer)
        {
            return true;
        }


    }
}

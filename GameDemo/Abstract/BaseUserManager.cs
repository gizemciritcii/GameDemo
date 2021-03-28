using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class BaseUserManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "    " + gamer.LastName + "Gamer eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer güncellendi");
        }
    }
}


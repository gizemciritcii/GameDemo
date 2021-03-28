using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService 
    {

      
        public IUserCheckService _userCheckService;

        public GamerManager()
        {
        }

        public GamerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }


        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"    "+ gamer.LastName+ gamer.Id+ gamer.NationalityId+gamer.BirthYear+ "Gamer eklendi");
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

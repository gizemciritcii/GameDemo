using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.GameName+game.GamePrice+game.GameID+ "oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("oyun güncllendi.");
        }

  
    }
}

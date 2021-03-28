using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);

        void Update(Game game);

    }
}

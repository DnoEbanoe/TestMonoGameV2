using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Db.Entity;

namespace TestGame.Db.Contract
{
    public interface IGameDataBase
    {
        Scena GetScenaByName(string scenaName);
    }
}

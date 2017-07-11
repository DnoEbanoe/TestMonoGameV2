using System.Linq;
using TestGame.Db.Contract;
using TestGame.Db.Entity;

namespace TestGame.Db.DataBase.EntityFramework
{
    public class EfGameDataBase: IGameDataBase
    {
        public DataBaseContext Context = new DataBaseContext();
        public Scena GetScenaByName(string scenaName)
        {
            return Context.Scenas.FirstOrDefault(scena => scena.Name == scenaName);
        }
    }
}

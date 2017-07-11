using TestGame.Db.Contract;
using TestGame.Db.DataBase.EntityFramework;

namespace TestGameV2
{
    public class Generator
    {
        public IGameDataBase GameDataBase { get; set; } = new EfGameDataBase();
    }
}

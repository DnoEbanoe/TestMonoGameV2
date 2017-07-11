using TestGame.Db.Contract;
using TestGame.Db.DataBase.EntityFramework;

namespace TestGameV2.UI
{
    public class Generator
    {
        public IGameDataBase GameDataBase { get; set; }

        public Generator(IGameDataBase gameDataBase)
        {
            GameDataBase = gameDataBase;
        }
        public void LoadContent(ScenaManager manager, string scenaName)
        {
            var scena = GameDataBase.GetScenaByName(scenaName);
        }
    }
}

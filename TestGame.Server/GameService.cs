using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestGame.Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "GameService" в коде и файле конфигурации.
    public class GameService : IGameService
    {
        public void CreateGameObject()
        {
            Console.WriteLine("Game obj created");
        }
    }
}

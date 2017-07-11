using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestGame.Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IGameService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        void CreateGameObject();
    }
}

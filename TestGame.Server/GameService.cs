using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestGame.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class GameService : IGameService
    {
        private static List<IGameServiceCallback> _callbackList = new List<IGameServiceCallback>();
        public void CreateGameObject()
        {
            Console.WriteLine("Game obj created");
        }
    }
}

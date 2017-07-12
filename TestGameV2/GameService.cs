using System;
using System.ServiceModel;
using TestGame.Db.Entity;
using TestGame.Server;

namespace TestGameV2
{
    public class GameService
    {
        public IGameService Service { get; }


        public GameService(IGameService service)
        {
            Service = service;
        }

        public void CreateObject(GameObject2D gameObject)
        {
            Service.CreateGameObject();
        }
    }
}

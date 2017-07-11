using System;
using System.ServiceModel;
using TestGame.Client.GameService;
using TestGame.Db.Entity;

namespace TestGameV2
{
    public class GameService
    {
        

        public GameService(IGameService service)
        {
            
        }

        public void CreateObject(GameObject2D gameObject)
        {
            channel.CreateGameObject();
        }
    }
}

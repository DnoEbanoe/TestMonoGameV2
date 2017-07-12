using System;
using System.ServiceModel;
using TestGame.Client;
using TestGame.Db.Contract;
using TestGame.Db.DataBase.EntityFramework;
using TestGame.Server;
using TestGameV2;
using TestGameV2.UI;

namespace TestGame.UI.Windows
{
#if WINDOWS || LINUX
    public static class Program
    {
        static readonly Uri Address = new Uri("http://localhost:8733/Design_Time_Addresses/TestGame.Server/GameService/");
        static readonly NetTcpBinding Binding = new NetTcpBinding();
        static ChannelFactory<IGameService> _factory;

        private static IGameService _channel = null;

        [STAThread]
        static void Main()
        {
            InstanceContext instanceContext = new InstanceContext(new GameServiceClientCallback());
            IGameService server = new Server.GameService(instanceContext);
            _factory = new ChannelFactory<IGameService>(Binding, new EndpointAddress(Address));
            _channel = _factory.CreateChannel();

            var manager = new ScenaManager();
            var service = new TestGameV2.GameService(_channel);
            var generator = new Generator(service);
            using (var game = new Game1(service, generator, manager))
                game.Run();
        }
    }

#endif
}

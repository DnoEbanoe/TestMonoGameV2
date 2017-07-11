using System;
using System.ServiceModel;
using TestGame.Client.GameService;
using TestGame.Db.Contract;
using TestGame.Db.DataBase.EntityFramework;
using TestGameV2;
using TestGameV2.UI;

namespace TestGame.UI.Windows
{
#if WINDOWS || LINUX
    public static class Program
    {
        static readonly Uri Address = new Uri("http://localhost:8733/Design_Time_Addresses/TestGame.Server/GameService/");
        static readonly BasicHttpBinding Binding = new BasicHttpBinding();
        static ChannelFactory<IGameService> _factory;

        private static IGameService _channel = null;
        static readonly IGameDataBase DataBase = new EfGameDataBase();

        [STAThread]
        static void Main()
        {
            _factory = new ChannelFactory<IGameService>(Binding, new EndpointAddress(Address));
            _channel = _factory.CreateChannel();

            var manager = new ScenaManager();
            var service = new GameService(_channel);
            var generator = new Generator(DataBase);
            using (var game = new Game1(service, generator, manager))
                game.Run();
        }
    }

#endif
}

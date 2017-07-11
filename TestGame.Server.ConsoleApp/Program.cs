using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Server.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(GameService));
            // Добавление конечной точки.
            host.AddServiceEndpoint(typeof(IGameService), new NetTcpBinding(),
                "net.tcp://localhost:9000/MyService");

            // Запуск хоста.
            host.Open();
            Console.ReadLine();
            host.Close();
        }
    }
}

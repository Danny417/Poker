using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Poker.Clients.UI.Console.GameServiceReference;

namespace Poker.Clients.UI.Console
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public static IGameManager Proxy
        {
            get
            {
                var ctx = new InstanceContext(new GameService());
                return new DuplexChannelFactory<IGameManager>(ctx, "NetTcpBinding_IGameManager").CreateChannel();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var user = new Player();
            user.UniqueIdentifier = Guid.NewGuid();
            System.Console.WriteLine("Hello! Please enter your name.");
            var userInput = System.Console.ReadLine();
            user.UserName = userInput;
            System.Console.WriteLine("1. Join the game");
            System.Console.WriteLine("2. Watch the game");
            System.Console.WriteLine("3. Leave the game");
            System.Console.WriteLine("Please select {1, 2, 3 or quit to terminate} : ");
            // loop continusly check user input
            while (!(userInput = System.Console.ReadLine()).ToLower().Equals("quit"))
            {
                switch (userInput)
                {
                    case "1":
                        Proxy.JoinGame(user);
                        break;
                    case "2":
                        Proxy.QuitGame(user);
                        break;
                    case "3":
                        Proxy.WatchGame(user);
                        break;
                    case "quit":
                        break;
                    default:
                        break;
                }
            }
        }
        
    }
}

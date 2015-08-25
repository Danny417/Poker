using System;
using System.ServiceModel;
using Poker.Clients.UI.Console.GameServiceReference;

namespace Poker.Clients.UI.Console
{
    class Program
    {
        /// <summary>
        /// Proxy provides an handler to call game manager
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
        /// Main program that executes when it starts
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
                        Proxy.WatchGame(user);
                        break;
                    case "3":
                        Proxy.QuitGame(user);
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

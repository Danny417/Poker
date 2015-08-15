using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Poker.Clients.UI.Console.GameServiceReference;

namespace Poker.Clients.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // By allowing client to call the service, 
            // we do not need to run the game on client anymore
          
            /*ITable gameTable = new Table();
            List<IPlayer> playersInTheGame = new List<IPlayer>();
            // Add two players
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            // Start the game
            gameTable.StartNewGame(playersInTheGame);*/


            //DEMO
            GameServiceClient gameClient =
                new GameServiceClient("NetTcpBinding_IGameService");

            System.Console.WriteLine("Hello! Please enter your name.");
            var userInput = System.Console.ReadLine();
            var user = gameClient.JoinGame(userInput);
            System.Console.WriteLine("Welcome, {0}", user.UserName);

            Display display = new Display(gameClient, user.UniqueIdentifier);

            // loop continusly check user input
            while (!(userInput = System.Console.ReadLine()).ToLower().Equals("q"))
            {
               gameClient.Chat(user.UniqueIdentifier, userInput);
            }
            
        }

        /// <summary>
        /// Timer class to update user display
        /// </summary>
        class Display
        {
            private GameServiceClient _client;
            private Guid _uid;

            public Display(GameServiceClient client, Guid uid)
            {
                this._client = client;
                this._uid = uid;

                Timer timer = new Timer(100);
                timer.Elapsed += timer_Elapsed;
                timer.Start();
            }

            void timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                foreach (var msg in _client.Update(_uid))
                {
                    System.Console.WriteLine(msg);
                }
            }
        }
        
    }
}

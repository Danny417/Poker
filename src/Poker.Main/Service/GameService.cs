using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Main.Service
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IGameService
    {
        #region IGameService Members
        public void JoinGame()
        {
            throw new NotImplementedException();
        }

        public void QuitGame()
        {
            throw new NotImplementedException();
        }

        public void WatchGame()
        {
            throw new NotImplementedException();
        }
    #endregion
    }
}

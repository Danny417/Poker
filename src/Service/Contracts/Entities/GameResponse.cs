using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts.Entities
{
    [DataContract]
    public class GameResponse
    {
        [DataMember]
        public bool Success { get; private set; }
        [DataMember]
        public string Message { get; private set; }

        public GameResponse(bool actionSuccess, string message)
        {
            Success = actionSuccess;
            Message = message;
        }
    }
}

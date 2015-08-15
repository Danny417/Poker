using Poker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Service.Contracts.Entities;

namespace Poker.Core
{
    public class SampleAiPlayer : IPlayer
    {
        List<Card> _startingHand;
        ITable _gameTable;

        IEnumerable<Card> PlayingHand
        {
            get
            {
                var allCards = _startingHand.Union(_gameTable.GetCommunityCards());
                return allCards; // TODO: PlayingHand should be the best 5-card hand a player has
            }
        }

        public SampleAiPlayer(ITable gameTable)
        {
            _startingHand = new List<Card>();
            _gameTable = gameTable;
        }

        public void AcceptCard(Card card)
        {
            _startingHand.Add(card);
        }

        public Move MakeMove()
        {
            return Move.Check;
        }

        public void ObserveGameState()
        {
            
        }

        public void ObserveMove()
        {
            
        }

        public IEnumerable<Card> RevealHand()
        {
            return _startingHand;
        }

        public IEnumerable<Card> RevealPlayingHand()
        {
            return PlayingHand;
        }
    }
}

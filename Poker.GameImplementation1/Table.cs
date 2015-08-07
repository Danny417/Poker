using Poker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.GameImplementation1
{
    public class Table : ITable
    {
        Stack<Card> _deck;
        List<IPlayer> _players;
        List<Card> _communityCards;
        Stack<Card> _upsideDownCommunityCards;

        #region ITable implementation

        public object GetGameLog()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            return _players;
        }

        public IEnumerable<Card> GetCommunityCards()
        {
            return _communityCards;
        }

        public void StartNewGame(IEnumerable<IPlayer> players)
        {
            _players.AddRange(players);
            _deck = getShuffledDeck();

            dealCards();
        }

        #endregion

        private void dealCards()
        {
            for (int i = 0; i < 3; i++)
            {
                _communityCards.Add(_deck.Pop());
            }
            for (int i = 0; i < 2; i++)
            {
                _upsideDownCommunityCards.Push(_deck.Pop());
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (IPlayer player in _players)
                {
                    player.AcceptCard(_deck.Pop());
                }
            }
        }

        private void flipCard()
        {
            if (_upsideDownCommunityCards.Count == 0)
            {
                throw new InvalidOperationException("There are no more upside-down cards to flip");
            }
            _communityCards.Add(_upsideDownCommunityCards.Pop());
        }

        private Stack<Card> getShuffledDeck()
        {
            // Create all 52 cards
            IEnumerable<CardSuit> suits = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>();
            IEnumerable<CardRank> ranks = Enum.GetValues(typeof(CardRank)).Cast<CardRank>();
            var deck = from r in ranks from s in suits select new Card(r, s);

            // Shuffle it
            return shuffleAndStack(deck.ToList());
        }

        /// <summary>
        /// Based on https://stackoverflow.com/questions/6165379/quickest-way-to-randomly-re-order-a-linq-collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private static Stack<T> shuffleAndStack<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return new Stack<T>(list);
        }
    }
}

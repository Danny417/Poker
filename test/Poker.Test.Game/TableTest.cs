using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker.Main;
using System.Collections.Generic;
using Poker.Core;
using System.Linq;

namespace Poker.Test.Game
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void TestDealingNewDeck()
        {
            // Create a new table. This will internally create and shuffle cards
            var table = new Table();

            // Retrieve private fields
            PrivateObject accessor = new PrivateObject(table);
            Stack<Card> deck = (Stack<Card>)accessor.Invoke("getShuffledDeck", null);

            // Set a breakpoint below to examine deck
            Assert.AreEqual(52, deck.Count());
            bool allUnique = deck.Distinct().Count() == deck.Count();
            Assert.AreEqual(true, allUnique);
        }
    }
}

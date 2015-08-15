using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker.Core;
using System.Linq;
using Poker.Service.Contracts.Entities;

namespace Poker.Test.UnitTests
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void TestDealingNewDeck()
        {
            // Create a new table. This will internally create and shuffle cards
            var table = new GameTable();

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

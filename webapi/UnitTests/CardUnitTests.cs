﻿//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using static webapi.Engines.CardEngine;


namespace webapi.UnitTests
{
    [TestFixture]
    public class CardUnitTests
    {
        [Test]
        public void IsDeckShuffled()
        {
            Deck testDeck = new Deck();
            List<Card> controlDeck = new List<Card>();
            string[] suits = { "♠", "♥", "♦", "♣" };
            int[] ranks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                { 
                    controlDeck.Add(new Card(suit, rank));
                }
            }

            //Debugging cards shuffled
            /*foreach (Card card in testDeck)
            {
                Console.WriteLine(card);
            }*/

            Assert.AreNotEqual(testDeck.cards, controlDeck);
        }

        [Test]
        public void deckCreates52Cards()
        {
            Deck testDeck = new Deck();
            Assert.AreEqual(52, testDeck.cards.Count);
        }
    }
}

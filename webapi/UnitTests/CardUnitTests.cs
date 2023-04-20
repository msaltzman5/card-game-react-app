//using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            Console.WriteLine("is this working?");

            Assert.AreNotEqual(testDeck._cards, controlDeck);
        }
    }
}

namespace webapi.Engines
{
    public class CardEngine
    {
        public class Card
        {
            public string Suit { get; }
            public int Rank { get; }

            public Card(string suit, int rank)
            {
                Suit = suit;
                Rank = rank;
            }

            public override string ToString()
            {
                return string.Format("{0} of {1}", Suit, Rank);
            }

            /*public wasteCardSlot ()
            {
                HtmlGenericControl cardDiv = new HtmlGenericControl("div");

                return cardDiv;
            }*/

        }

        public class Deck
        {
            public List<Card> _cards { get; }

            public Deck()
            {
                _cards = GetShuffledDeck();
            }

            public List<Card> GetShuffledDeck()
            {
                List<Card> deck = new List<Card>();
                string[] suits = { "♠", "♥", "♦", "♣" };
                int[] ranks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

                foreach (var suit in suits)
                {
                    foreach (var rank in ranks)
                    {
                        deck.Add(new Card(suit, rank));
                    }
                }
                Shuffle(deck);
                return deck;
            }

            private void Shuffle<T>(IList<T> list)
            {
                Random random = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    // Use temp value to swap randomly (works backwards)
                    T temp = list[k];
                    list[k] = list[n];
                    list[n] = temp;
                }
            }
        }
    }
}

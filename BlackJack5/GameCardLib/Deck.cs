using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Deck
    {
        private List<Card> cards;
        private Random rng;
        public Deck()
        {
            rng = new Random();
            cards = new List<Card>();
            shuffle();
        }
        public void reset()
        {
            cards.Clear();
            for (int i = 1; i < (13) + 1; i++)
            {
                cards.Add(new Card(CardType.Clubs, (CardValue)i));
            }

            for (int i = 1; i < (13) + 1; i++)
            {
                cards.Add(new Card(CardType.Diamonds, (CardValue)i));
            }

            for (int i = 1; i < (13) + 1; i++)
            {
                cards.Add(new Card(CardType.Spades, (CardValue)i));
            }

            for (int i = 1; i < (13) + 1; i++)
            {
                cards.Add(new Card(CardType.Hearts, (CardValue)i));
            }
        }

        public void shuffle()
        {
            reset();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card drawCard()
        {
            if(cards.Count == 0)
            {
                shuffle();
            }
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}

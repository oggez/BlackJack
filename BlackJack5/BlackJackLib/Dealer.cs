using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    class Dealer
    {
        private Player player;
        private Deck deck;
        private List<Card> cards;

        public Dealer(Deck deck, Player player)
        {
            this.player = player;
            this.deck = deck;
            cards = new List<Card>();
        }
        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public void reset()
        {
            cards.Clear();
        }

        public List<Card> getCards()
        {
            return cards;
        }

        public Boolean checkWin()
        {
            return false;
        }

    }
}

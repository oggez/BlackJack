using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    class Player
    {
        private List<Card> cards;

        public Player()
        {
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

        public Boolean checkWin()
        {
            return false;
        }
        public List<Card> getCards()
        {
            return cards;
        }
    }
}

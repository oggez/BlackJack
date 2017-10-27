using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    public class Dealer : IPlayer
    {
        private TableHandler.CardDelegate dDelegate;
        private List<Card> cards;

        public Dealer(TableHandler.CardDelegate dDelegate)
        {
            this.dDelegate = dDelegate;
            cards = new List<Card>();
        }
        public void addCard(Card card)
        {
            
            cards.Add(card);
            dDelegate(card, this, false);

        }

        public void reset()
        {
            cards.Clear();
        }
        public int countValue()
        {
            int values = 0;
            List<Card> aces = new List<Card>();
            foreach (Card card in cards)
            {
                if((int)card.CardValue != 1)
                {
                    values += (int)card.CardValue >= 10 ? 10 : (int)card.CardValue;
                }
                else
                {
                    aces.Add(card);
                }
            }
            foreach(Card card in aces)
            {
                values += values >= 11 ? 1 : 11;
            }

            return values;
        }
        public List<Card> getCards => cards;
    }
}

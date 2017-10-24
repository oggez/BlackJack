using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public enum CardType
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs
        
    }
    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    public class Card
    {
        private CardType cardType;
        private CardValue cardValue;

        public Card(CardType cardType, CardValue cardValue)
        {
            this.cardType = cardType;
            this.cardValue = cardValue;
        }

        public CardType CardType => cardType;

        public CardValue CardValue => cardValue;

    }
}

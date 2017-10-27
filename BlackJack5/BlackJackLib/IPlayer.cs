using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    public interface IPlayer
    {

        void addCard(Card card);

        void reset();

        int countValue();

        List<Card> getCards { get; }

    }
}

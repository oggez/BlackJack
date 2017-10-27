using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    public class TableHandler
    {
        public delegate void CardDelegate(Card card, IPlayer player, Boolean win);
        private CardDelegate dDelegate;
        private Dealer dealer;
        private Player player;
        private Deck deck;

        public TableHandler()
        {
            deck = new Deck();
            
        }


        public void hit()
        {
          player.addCard(deck.drawCard());
          if(player.countValue() > 21)
            {
                dDelegate(null, dealer, true);
            }
        }

        public void stand()
        {
           dealer.addCard(deck.drawCard());
            if (dealer.countValue() > 21)
            {
                dDelegate(null, player, true);
            } else if (dealer.countValue() >= player.countValue())
            {
                dDelegate(null, dealer, true);
            }
            else
            {
                stand();
            }
        }

        public void newGame(TableHandler.CardDelegate dDelegate)
        {
            this.dDelegate = dDelegate;
            player = new Player(dDelegate);
            dealer = new Dealer(dDelegate);
            player.addCard(deck.drawCard());
            dealer.addCard(deck.drawCard());
            player.addCard(deck.drawCard());

        }

        public void shuffle()
        {
            deck.shuffle();
        }
    }
}

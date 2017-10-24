using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace BlackJackLib
{
    public delegate void BlackJackHandler();
    public class TableHandler
    {
        private Dealer dealer;
        private Player player;
        private Deck deck;

        public TableHandler()
        {

        }


        public void makeMove()
        {


        }

        public void newGame()
        {
            deck = new Deck();
            deck.shuffle();
            player = new Player();
            dealer = new Dealer(deck, player);

            player.addCard(deck.drawCard());
            dealer.addCard(deck.drawCard());
            player.addCard(deck.drawCard());
        }


        public List<Card> playerCards()
        {
            return player.getCards();
        }

        public List<Card> dealerCards()
        {
            return dealer.getCards();
        }

        

    }
}

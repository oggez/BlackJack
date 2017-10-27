using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlackJackLib;
using GameCardLib;

namespace BlackJack5
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TableHandler tableHandler;
        private List<Card> player = new List<Card>();
        private List<Card> dealer = new List<Card>();
        public MainWindow()
        {
            tableHandler = new TableHandler();
            InitializeComponent();
            
        }

  

        public void updateCard(Card card, IPlayer player, Boolean win)
        {
            if (win)
            {
                if (player is Player)
                {
                    winner(player);
                }
                else if (player is Dealer)
                {
                    winner(player);
                }
            }
            else
            {
                if (player is Player)
                {
                    
                    updatePlayerCards(card);
                    lblPlayerCount.Content = "Player Count = " + player.countValue();
                }
                else if (player is Dealer)
                {
                    
                    updateDealerCard(card);
                    lblDealerCount.Content = "Dealer Count = " + player.countValue();
                }
            }
        }
        public void updatePlayerCards(Card playerCards)
        {
            player.Add(playerCards);
            int spriteY = (int)playerCards.CardType;
            int spriteX = (int)playerCards.CardValue - 1;
            Image croppedImage = new Image();
            CroppedBitmap cb = new CroppedBitmap((BitmapSource)this.Resources["SpriteImage"],
                new Int32Rect(225 * spriteX, 315 * spriteY, 225, 315));
            switch (player.Count)
            {
                case 1:
                    PlayerCard1.Source = cb;
                    break;
                case 2:
                    PlayerCard2.Source = cb;
                    break;
                case 3:
                    PlayerCard3.Source = cb;
                    break;
                case 4:
                    PlayerCard4.Source = cb;
                    break;
                case 5:
                    PlayerCard5.Source = cb;
                    break;
                case 6:
                    PlayerCard6.Source = cb;
                    break;
                case 7:
                    PlayerCard7.Source = cb;
                    break;
                case 8:
                    PlayerCard8.Source = cb;
                    break;
            }
        }
        public void updateDealerCard(Card dealerCards)
        {
            dealer.Add(dealerCards);
            int spriteY = (int)dealerCards.CardType;
            int spriteX = (int)dealerCards.CardValue - 1;
            Image croppedImage = new Image();
            CroppedBitmap cb = new CroppedBitmap((BitmapSource)this.Resources["SpriteImage"],
                new Int32Rect(225 * spriteX, 315 * spriteY, 225, 315));
            switch (dealer.Count)
            {
                case 1:
                    DealerCard1.Source = cb;
                    break;
                case 2:
                    DealerCard2.Source = cb;
                    break;
                case 3:
                    DealerCard3.Source = cb;
                    break;
                case 4:
                    DealerCard4.Source = cb;
                    break;
                case 5:
                    DealerCard5.Source = cb;
                    break;
                case 6:
                    DealerCard6.Source = cb;
                    break;
                case 7:
                    DealerCard7.Source = cb;
                    break;
                case 8:
                    DealerCard8.Source = cb;
                    break;

            }
            
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            lblDealerCount.Content = "Dealer Count = 0";
            lblPlayerCount.Content = "Dealer Count = 0";
            btnStand.IsEnabled = true;
            btnHit.IsEnabled = true;
            btnShuffle.IsEnabled = false;
            player.Clear();
            dealer.Clear();
            resetImages();
            tableHandler.newGame(new TableHandler.CardDelegate(updateCard));
        }

        public void winner(object obj)
        {
            if (obj is Player)
            {
                MessageBox.Show("Player won");
            }
            else if (obj is Dealer)
            {
                MessageBox.Show("Dealer won");
            }
            btnStand.IsEnabled = false;
            btnHit.IsEnabled = false;
            btnShuffle.IsEnabled = true;
        }

        public void resetImages()
        {
            DealerCard1.Source = null;
            PlayerCard1.Source = null;
            DealerCard2.Source = null;
            PlayerCard2.Source = null;
            DealerCard3.Source = null;
            PlayerCard3.Source = null;
            DealerCard4.Source = null;
            PlayerCard4.Source = null;
            DealerCard5.Source = null;
            PlayerCard5.Source = null;
            DealerCard6.Source = null;
            PlayerCard6.Source = null;
            DealerCard7.Source = null;
            PlayerCard7.Source = null;
            DealerCard8.Source = null;
            PlayerCard8.Source = null;
        }
        private void btnStand_Click(object sender, RoutedEventArgs e)
        {
            tableHandler.stand();
        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            tableHandler.hit();
        }

        private void btnShuffle_Click(object sender, RoutedEventArgs e)
        {
            tableHandler.shuffle();
        }
    }
}

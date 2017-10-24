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
        
        public MainWindow()
        {
            tableHandler = new TableHandler();
            InitializeComponent();
        }

  

        public void update()
        {


            List<Card> playerCards = tableHandler.playerCards();

            int spriteY = (int)playerCards[0].CardType;
            int spriteX = (int)playerCards[0].CardValue - 1;
            Image croppedImage = new Image();
            CroppedBitmap cb = new CroppedBitmap((BitmapSource)this.Resources["SpriteImage"],
                new Int32Rect(225 * spriteX, 315 * spriteY, 225, 315));
            PlayerCard1.Source = cb;

            updateDealerCard();

            update2ndPlayerCard();

        }

        private void update2ndPlayerCard()
        {
            List<Card> playerCards = tableHandler.playerCards();
            int spriteY = (int)playerCards[1].CardType;
            int spriteX = (int)playerCards[1].CardValue - 1;
            Image croppedImage = new Image();
            CroppedBitmap cb = new CroppedBitmap((BitmapSource)this.Resources["SpriteImage"],
                new Int32Rect(225 * spriteX, 315 * spriteY, 225, 315));
            PlayerCard2.Source = cb;
        }

        public void updateDealerCard()
        {
            List<Card> dealerCards = tableHandler.dealerCards();
            int spriteY = (int)dealerCards[0].CardType;
            int spriteX = (int)dealerCards[0].CardValue - 1;
            Image croppedImage = new Image();
            CroppedBitmap cb = new CroppedBitmap((BitmapSource)this.Resources["SpriteImage"],
                new Int32Rect(225 * spriteX, 315 * spriteY, 225, 315));
            DealerCard1.Source = cb;
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            tableHandler.newGame();

            update();
        }

        private void btnStand_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

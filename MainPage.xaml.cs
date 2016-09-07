using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static CastleCardGame.Card;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CastleCardGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Random rnd = new Random();
       
            int card = rnd.Next(52);
            int x = card;
            this.InitializeComponent();

            TwoClubs twoclubs = new TwoClubs();
            UIElementCollection coll;
            coll = Field.Children;
            TwoClubs.Field = coll[0];
            TwoClubs.Fiel = coll[1];
            //Game gam = new Game();
           
       for(int w=0; w<52;w++)
            {
                Game.pile[w] = coll[w];
                /////maybe just have the Game object own all of the piles hands deck, and have two player objects have owners of the piles


            }
            //TwoClubs.Fiel.Visibility = Visibility.Collapsed;

            //var list = source.Select(s => new { ID = s.ID, Name = s.Name }).ToList();

        }

        private void clubs2_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
           // TwoClubs.MovetoField();
        }
        public void InitializeImages(CardType ct)
        {
         //////   Field = field;
         //////   PlayerHand = playerhand;
         //////   CompHand = comphand;
        }

        private void clubs4field_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            int x = 0;
        }
    }
}

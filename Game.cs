using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image=Windows.UI.Xaml.Controls.Image;
using CardType = CastleCardGame.Card.CardType;
using Windows.UI.Xaml;
namespace CastleCardGame
{
    class Game
    {
        public static Card[] Cards;
        public static UIElement[] pile;
        public enum choosecastles { notstarted, bottomchosen, topchosen };
        public static choosecastles castleselection;

          public Game()
         {
             Cards = new Card[52];


  
         }
    
        public static void TurnSelector()
        {

        }
     
    }
}

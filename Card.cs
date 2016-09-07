
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Image = Windows.UI.Xaml.Controls.Image;

namespace CastleCardGame
{
     public class Card
    {
    

        public static Image Field;
         public static Image PlayerHand;
        public static Image CompHand;
        public static Image Deck;
       
        public static bool tapped;
        public enum Location { deck, field, playerhand, comphand, outofplay };
        public static Location location;
        public enum CardType {ace,two,three,four,five,six,seven,eight,nine,ten,jack,queen,king};
        public static CardType cardtype;
     
        public Card(CardType ct)
        {
            cardtype = ct;
            tapped = false;       
            MovetoDeck();
        }
        public static void MovetoField()
        {
            PlayerHand.Visibility = Visibility.Collapsed;
            CompHand.Visibility = Visibility.Collapsed;
            Field.Visibility = Visibility.Visible;
            location = Location.field;
        }

       public static void MovetoCompHand()
        {
            PlayerHand.Visibility = Visibility.Collapsed;
            CompHand.Visibility = Visibility.Visible;
            Field.Visibility = Visibility.Collapsed;
            location = Location.comphand;
        }
         public static void MovetoPlayerHand()
        {

            PlayerHand.Visibility = Visibility.Visible;
            CompHand.Visibility = Visibility.Collapsed;
            Field.Visibility = Visibility.Collapsed;
            location = Location.playerhand;
        }
        public static void MovetoOutofPlay()
        {

            PlayerHand.Visibility = Visibility.Collapsed;
            CompHand.Visibility = Visibility.Collapsed;
            Deck.Visibility = Visibility.Collapsed;
            Field.Visibility = Visibility.Collapsed;
            location = Location.outofplay;
        }
        public static void MovetoDeck()
        {

            PlayerHand.Visibility = Visibility.Collapsed;
            CompHand.Visibility = Visibility.Collapsed;
            Field.Visibility = Visibility.Collapsed;
            location = Location.deck;
        }


    }
}


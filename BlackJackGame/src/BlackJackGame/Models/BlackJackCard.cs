using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class BlackJackCard: Card
    {
        public bool FaceUp { get; set; }
        public int Value { get; set; }

        public BlackJackCard(FaceValue faceValue, Suit suit) : base(faceValue, suit)
        {
        }

        public void TurnCard()
        {
            throw new NotImplementedException();
        }
    }
}

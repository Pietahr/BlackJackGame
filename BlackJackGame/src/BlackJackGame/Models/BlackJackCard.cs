using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class BlackJackCard: Card
    {
        public bool FaceUp { get; set; }
        public int Value
        {
            get
            {
                if (FaceUp == false)
                    return 0;
                if (FaceValue == FaceValue.Queen || FaceValue == FaceValue.Jack || FaceValue == FaceValue.King)
                    return 10;
                return FaceValue.GetHashCode();
            }
        }

        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
        {
            FaceUp = false;
        }

        public void TurnCard()
        {
            if (FaceUp == false)
            {
                FaceUp = true;
            }
            else FaceUp = false;
        }
    }
}

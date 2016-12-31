using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class Hand
    {
        private IList<BlackJackCard> _cards;

        public int NrOfCards => _cards.Count;
        public int Value => CalculateValue();
        public IEnumerable<BlackJackCard> Cards { get {return _cards;}}

        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }

        public void AddCard(BlackJackCard blackJackCard)
        {
            _cards.Add(blackJackCard);
        }

        private int CalculateValue()
        {
            int value = 0;
            IList<BlackJackCard> aceCards = new List<BlackJackCard>();

            foreach (BlackJackCard c in _cards )
            {
                if (c.FaceValue == FaceValue.Ace)
                {
                    aceCards.Add(c);
                }
                else
                value += c.Value;
            }

            foreach (BlackJackCard ace in aceCards)
            {
                if (value <= 10)
                {
                    value += 11;
                }
                else value += 1;
            }
            return value;
        }

        public void TurnAllCardsFaceUp()
        {
            foreach (BlackJackCard c in _cards)
            {
                if(!c.FaceUp)
                    c.TurnCard();
            }
        }
    }
}

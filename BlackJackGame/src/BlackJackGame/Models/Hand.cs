using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class Hand
    {
        private IList<BlackJackCard> _cards;

        public int NrOfCards { get; }
        public int Value { get; }
        public IEnumerable<BlackJackCard> Cards { get; set; }

        public Hand()
        {
            
        }

        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new NotImplementedException();
        }

        public int CalculateValue()
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class Deck
    {

        #region fields

        private Random _random;
        private IList<BlackJackCard> _cards;

        #endregion

        public Deck()
        {
            
        }

        #region methods

        public BlackJackCard Draw()
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}

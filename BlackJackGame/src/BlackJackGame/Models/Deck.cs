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
            _cards = new List<BlackJackCard>();

            foreach(Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue f in Enum.GetValues(typeof(FaceValue)))
                {
                    _cards.Add(new BlackJackCard(s,f));
                }
            }
        }

        #region methods

        public BlackJackCard Draw()
        {
            BlackJackCard card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            for (int i = 1; i < _cards.Count * 3; i++)
            {
                int randomPosition = _random.Next(0, _cards.Count);
                BlackJackCard card = _cards[randomPosition];
                _cards.RemoveAt(randomPosition);
                _cards.Add(card);
            }
        }

        #endregion

    }
}

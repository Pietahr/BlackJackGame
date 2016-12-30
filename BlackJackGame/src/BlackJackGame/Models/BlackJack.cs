using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class BlackJack
    {
        private Deck _deck;

        public bool FaceUp { get; set; }
        public bool FaceDown { get; set; }
        public Hand DealerHand { get; }
        public Hand PlayerHand { get; }

        public BlackJack()
        {
            
        }

        public BlackJack(Deck deck)
        {
            _deck = deck;
        }

        public void AddCardToHand(Hand hand, bool faceUp, BlackJackCard card)
        {
            throw new NotImplementedException();
        }

        public void AdjustGameState(GameState? gamestate)
        {
            throw new NotImplementedException();
        }

        public void Deal()
        {
            throw new NotImplementedException();
        }

        public string GameSummary()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        public void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }
    }
}

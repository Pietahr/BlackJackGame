using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using BlackJackGame.Models;

namespace BlackJackGame.Tests.Models
{
    public class DeckTest
    {
        private Deck _deck;

        public DeckTest()
        {
            _deck = new Deck();
        }
        [Fact]
        public void Draw_ReturnsBlackJackCard()
        {
            Assert.IsType<BlackJackCard>(_deck.Draw());
        }
    }
}

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
        public void NewDeck_Contains52BlackJackCards()
        {
            for (int i = 0; i <= 51; i++)
            {
                Assert.IsType<BlackJackCard>(_deck.Draw());
            }

        }

        [Fact]
        public void Draw_DeckNotEmpty_ReturnsBlackJackCard()
        {
            Assert.IsType<BlackJackCard>(_deck.Draw());
        }

        [Fact]
        public void Draw_DeckEmpty_ThrowsException()
        {
            for (int i = 1; i <= 52; i++)
            {
                _deck.Draw();
            }
            Assert.Throws<InvalidOperationException>(() => _deck.Draw());
        }

        [Fact]
        public void NewDEck_Contains52DifferentCards()
            {
                BlackJackCard card;
                int[] suits = new int[4];
                int[] faceValues = new int[13];
                for (int i = 1; i <= 52; i++)
                {
                    card = _deck.Draw();
                    suits[(int)card.Suit - 1]++;
                    faceValues[(int)card.FaceValue - 1]++;
                }
                for (int i = 0; i < 4; i++)
                {
                    Assert.Equal(13, suits[i]);
                }
                for (int i = 0; i < 13; i++)
                {
                    Assert.Equal(4, faceValues[i]);
                }
            }
}
}

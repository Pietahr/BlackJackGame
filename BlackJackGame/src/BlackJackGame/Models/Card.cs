namespace BlackJackGame.Models
{
    public class Card
    {
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }

        #region constructor

        public Card(FaceValue faceValue, Suit suit)
        {
            FaceValue = faceValue;
            Suit = suit;
        }

        #endregion
    }
}

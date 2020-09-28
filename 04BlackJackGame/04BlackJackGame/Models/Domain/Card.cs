using BlackJackGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04BlackJackGame.Models.Domain
{
    class Card
    {
        #region properties
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }

        #endregion

        #region constructors
        public Card(Suit suit, FaceValue faceValue)
        {
            throw new NotImplementedException;
        }
        #endregion
    }
}

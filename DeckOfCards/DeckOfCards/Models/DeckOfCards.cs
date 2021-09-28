using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{


    public class DeckResponse
    {
        public bool Success { get; set; }
        public string Deck_id { get; set; }
        public int Remaining { get; set; }
        public bool Shuffled { get; set; }
    }

    public class DrawCardResponse
    {
        public bool Success { get; set; }
        public string Deck_id { get; set; }
        public Card[] Cards { get; set; }
        public int Remaining { get; set; }
    }

    public class Card
    {
        public string Code { get; set; }
        public string Image { get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public class Images
    {
        public string Svg { get; set; }
        public string Png { get; set; }
    }

 
}

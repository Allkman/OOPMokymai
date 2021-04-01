using DeckOfCards.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Card
    {
        public Card(ECardSuite suite, CardRank rank)
        {
            Suite = suite;
            Rank = rank;
        }

        public ECardSuite Suite { get; set; }
        public CardRank Rank { get; set; }
    }
}

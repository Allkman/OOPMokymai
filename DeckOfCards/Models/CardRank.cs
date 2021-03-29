using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class CardRank
    {
        public CardRank(string name, int rankNumber)
        {
            Name = name;
            RankNumber = rankNumber;
        }

        public string Name { get; set; }
        public int RankNumber { get; set; }
    }
}

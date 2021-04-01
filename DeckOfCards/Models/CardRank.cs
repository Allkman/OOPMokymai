using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class CardRank
    {
        public CardRank(string cardName, int rankNumber)
        {
            CardName = cardName;
            RankNumber = rankNumber;
        }

        public string CardName { get; set; }
        public int RankNumber { get; set; }
    }
}

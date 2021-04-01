using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class AllCardsRanked
    {
        public virtual CardRank Two => new CardRank("Two", 2); // string keiciu i enum
        public virtual CardRank Three => new CardRank("Three", 3);
        public virtual CardRank Four => new CardRank("Four", 4);
        public virtual CardRank Five => new CardRank("Five", 5);
        public virtual CardRank Six => new CardRank("Six", 6);
        public virtual CardRank Seven => new CardRank("Seven", 7);
        public virtual CardRank Eight => new CardRank("Eight", 8);
        public virtual CardRank Nine => new CardRank("Nine", 9);
        public virtual CardRank Ten => new CardRank("Ten", 10);
        public virtual CardRank Jack => new CardRank("Jack", 11);
        public virtual CardRank Queen => new CardRank("Queen", 12);
        public virtual CardRank King => new CardRank("King", 13);
        public virtual CardRank Ace => new CardRank("Ace", 14);

        public List<CardRank> CardDeck => new List<CardRank>
        {
            Two, Three, Four, Five, Six, Seven, Eight, Nine,
            Ten, Jack, Queen, King, Ace
        };
    }
}

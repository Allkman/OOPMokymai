using DeckOfCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardWarGame.Models
{
    public class Player : Person
    {
        public Player(string firstName, string lastName) : base (firstName, lastName)
        {
            CardsInHand = new List<Card>();
        }
        public List<Card> CardsInHand { get; set; }

        
    }
}

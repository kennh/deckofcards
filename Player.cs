using System;
using System.Collections.Generic;

namespace ConsoleApplication
{

    public Class Player()
    {
        public string name;
        private List<Card> hand;

        public Player() 
        {
            hand = new List<Card>();
            hand.Add(new Card("cool", 2));
        }

        public void DrawFrom(Deck currentDeck)
        {
            hand.Add(currnentDeck.Deal());
        }

        public Card discard(int idx)
        {
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }

    }
}
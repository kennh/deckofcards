using System;
using System.Collections.Generic;

namespace ConsoleApplication
{


    public class Card()
    {
        public string stringVal {
            get 
            {
                if(val > 1 && Val < 11)
                {
                    return Val.ToString();
                }
                else if (val == 11)
                {
                    stringVal = "Jack";
                }
                else if (val == 12)
                {
                    stringVal = "Queen";
                }
                else if (val == 13)
                {
                    stringVal = "King";
                }
                else if (val == 1)
                {
                    stringVal = "Ace";
                }
                else
                {
                    stingVal = "Joker"
                }
            
        public string suit;
        public int val;

        public Card(string cardSuit, int numVal)
        {
            suit = cardSuit;
            val = numVal;
        }

        public override string ToString()
        {
            return string + " of " + suit;
        }
        
        
     
        // make constructor class here for suit of cards
        // create if else or switch classes for the cards "strings" saying 1 = ace
        // so each suit will encompass a certain number i.e. 1-13 clubs, 14-26 spades, 27-39 hearts, 40-52 
        // 
    }
}
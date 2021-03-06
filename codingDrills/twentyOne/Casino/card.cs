﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
    //this is a constructor in which the values are default for the class
        public Suit Suit { get; set; } // no longer a string, now an enum data type "Suit"
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    } 
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    
}


//public Card()
//{
//    Suit = "Spades";
//    Face = "Two";
//}

//public enum Suit
//{
//    Clubs=4,
//    Diamonds=10,
//    Hearts=12,
//    Spades=15
//}
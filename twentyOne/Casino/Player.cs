﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator +(Game game, Player player) //(what we are adding together)
        {
            game.Players.Add(player); //(item to add)
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player); //(item to remove)
            return game;
        }
    }
}

//public class Player<T>
//    {
//        public List<T> Hand { get; set; }
//        public int Balance { get; set; }
//        public string Name { get; set; }
//        public bool isActivelyPlaying { get; set; }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //constructor chaining. Below allows us to only pass in a single name
        public Player(string name) : this(name, 100) { }
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
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        //operator overloading is when you add a method to an operator so it does something other than it normally would
        //here we are making + and - add a player to the game players list.
        public static Game operator +(Game game, Player player)//operator overload
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)//operator Overload
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

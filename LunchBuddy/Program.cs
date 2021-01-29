using System;
using System.Collections.Generic;

namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant1 = new Restaurant();
            Console.WriteLine($"We are going to {restaurant1.Name}");

            var myBuddy1 = new LunchBuddy("Dwight", "Shrude");
            myBuddy1.Eat();

            var myBuddy2 = new LunchBuddy("Jim", "Halpert");
            var myBuddy3 = new LunchBuddy("Pamela", "Beesley");
            var myBuddy4 = new LunchBuddy("Creed", "Bratton");
            var myBuddy5 = new LunchBuddy("Meredith", "Palmer");

            var companions = new List<LunchBuddy> { myBuddy1, myBuddy2, myBuddy3, myBuddy4, myBuddy5 };

            myBuddy5.Eat(companions);
            myBuddy5.Eat("Pizza by Alfredo", companions);
        }
    }
}
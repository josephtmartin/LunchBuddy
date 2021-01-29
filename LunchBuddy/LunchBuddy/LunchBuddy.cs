using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddy
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string Eat()
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant}");
            return randomRestaurant;
        }
        public void Eat(string food) => Console.WriteLine($"{FirstName} {LastName} ate {food} at the office");

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant}");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var randomRestaurant = restaurant.Name;
            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant} eating {food} with {companions[0].FirstName} and {companions[1].FirstName}");
        }
    }
}

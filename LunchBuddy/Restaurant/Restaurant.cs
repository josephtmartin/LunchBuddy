using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddy
{

    class Restaurant
    {
        private List<string> _restaurantNames = new List<string> { "CiCi's Pizza", "El Mexico", "Chili's", "Chick-fil-a", "Camino Real", "O' Charley's", "Nacho's" };
        public string Name { get; set; }

        public Restaurant()
        {
            var random = new Random();
            int num = random.Next(_restaurantNames.Count);
            Name = _restaurantNames[num];
        }
    }
}

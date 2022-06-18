using System;
using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemomoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemomoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 1, Name = "Tersiguels", Cuisine = CuisineType.French },
                new Restaurant { Id = 1, Name = "Mango Grove", Cuisine = CuisineType.Indian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}


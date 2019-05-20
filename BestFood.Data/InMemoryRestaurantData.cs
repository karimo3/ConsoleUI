using System.Collections.Generic;
using System.Linq;
using BestFood.Core;

namespace BestFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id =1, Name = "Carve Pizza", Location = "New York", Cuisine = CuisineType.Italian },
                new Restaurant {Id =2, Name = "Hemo's Spot", Location = "Brooklyn", Cuisine = CuisineType.Mexican },
                new Restaurant {Id =3, Name = "Hazaar Kebab", Location = "Queens", Cuisine = CuisineType.None }
            };
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);

        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant Update(Restaurant updatedrestaurant)
        {

            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedrestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedrestaurant.Name;
                restaurant.Location = updatedrestaurant.Location;
                restaurant.Cuisine = updatedrestaurant.Cuisine;
            }

            return restaurant;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);

            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return restaurants.Count();
        }
    }
}
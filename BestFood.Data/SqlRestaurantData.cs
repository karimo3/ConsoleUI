using System.Collections.Generic;
using BestFood.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BestFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestaurantDbContext restaurantDb;

        public SqlRestaurantData(RestaurantDbContext restaurantDb)
        {
            this.restaurantDb = restaurantDb;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurantDb.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return restaurantDb.SaveChanges();
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if (restaurant != null)
            {
                restaurantDb.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return restaurantDb.Restaurants.Find(id);
        }

        public int GetCountOfRestaurants()
        {
            return restaurantDb.Restaurants.Count();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in restaurantDb.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = restaurantDb.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}

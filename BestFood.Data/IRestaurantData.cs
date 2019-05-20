using BestFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant restaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurants();

        int Commit();
    }
}

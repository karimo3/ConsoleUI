using Restaurants.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Data
{
    public interface IPlayersData
    {
        IEnumerable<Player> GetPlayersByName(string name);
        Player GetById(int id);
        Player Update(Player restaurant);
        Player Add(Player newRestaurant);
        Player Delete(int id);
        int GetCountOfRestaurants();

        int Commit();

    }
}

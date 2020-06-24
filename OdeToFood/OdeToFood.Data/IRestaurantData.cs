using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;


namespace OdeToFood.Data
{
	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetAllRestaurants();

		Restaurant GetRestaurantByID(int ID);

		IEnumerable<Restaurant> GetByName(string name);
		
	}
}

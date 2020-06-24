using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
	public class RestaurantData : IRestaurantData
	{
		List<Restaurant> Restaurants;
		public RestaurantData()
		{
			Restaurants = new List<Restaurant>
			{
				new Restaurant {RestaurantId = 1, Name="Chicken Shop", Cuisine= CuisineType.none, Location="London"},
				new Restaurant {RestaurantId = 2, Name="Abbey Kababey", Location="london", Cuisine=CuisineType.Turkish, },
				new Restaurant {RestaurantId = 3, Name="Shoryu Ramen", Cuisine=CuisineType.Japanese, Location="London" }
			};
		}



		public IEnumerable<Restaurant> GetAllRestaurants()
		{
			return from r in Restaurants			//I don't like query string. 
				   orderby r.Name
				   select r;
		}

		public IEnumerable<Restaurant> GetByName(string name)
		{
			return null; 
		}

		public Restaurant GetRestaurantByID(int ID)
		{
			return Restaurants.FirstOrDefault(r => r.RestaurantId == ID || r.Name == null) ; //linq query is better. (my opinion)
		}

		/*return from r in restaurants 
		 * where string.IsnullOrEmpty(name) || r.Name.StartsWith(name)
		 * orderby r.Name
		 * select r;
		 * 
		 * string name = null;
		 */
	}
}

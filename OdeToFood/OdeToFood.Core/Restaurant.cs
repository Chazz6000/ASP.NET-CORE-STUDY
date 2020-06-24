using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OdeToFood.Core
{
	public class Restaurant
	{
		public int RestaurantId { get; set; }

		public string Name { get; set; }
		public string Location { get; set; }

		public CuisineType Cuisine { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages
{
    public class RestaurantsModel : PageModel
    {
		private readonly IConfiguration configuration;
		private readonly IRestaurantData restaurantData;

		public string Message { get; set; }
		public  string Message2{ get; set; }

		public IEnumerable<Restaurant> Restaurants { get; set; }
		[BindProperty(SupportsGet =true)]
		public string SearchTerm { get; set; }

		public RestaurantsModel(IConfiguration configuration, IRestaurantData restaurantData)
		{
			this.configuration = configuration;
			this.restaurantData = restaurantData;
		}

		public void OnGet()
        {
            Message = "Hello There from page Model ";

			Message2 = configuration["Message"];

			Restaurants = restaurantData.GetByName(SearchTerm);
			


        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzalogs.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PizzasController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<TPizza> Get()
		{
			List<TPizza> pizzas = new List<TPizza>(); ;

			pizzas.Add(new TPizza {
				productID	= 1,
				flavor		= "Três queijos",
				price		= 50.00m
			});

			pizzas.Add(new TPizza
			{
				productID	=  2,
				flavor		= "Frango com requeijão",
				price		= 59.90m
			});

			pizzas.Add(new TPizza
			{
				productID	=  3,
				flavor		= "Mussarela",
				price		= 42.50m
			}); 

			pizzas.Add(new TPizza
			{
				productID	=  4,
				flavor		= "Calabresa",
				price		= 42.50m
			}); 

			pizzas.Add(new TPizza
			{
				productID	= 5,
				flavor		= "Pepperoni",
				price		= 55.00m
			});

			pizzas.Add(new TPizza
			{
				productID	= 6,
				flavor		= "Portuguesa",
				price		= 45.00m
			});

			pizzas.Add(new TPizza
			{
				productID	= 7,
				flavor		= "Veggie",
				price		= 59.99m
			});

			return pizzas;
		}
	}
}

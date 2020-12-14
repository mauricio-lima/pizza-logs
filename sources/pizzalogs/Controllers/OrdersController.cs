using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace pizzalogs.Controllers
{
	[Route("orders")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private IOrdersStorage OrdersStorage;

		public OrdersController(IOrdersStorage OrdersStorage)
		{
			this.OrdersStorage = OrdersStorage;
		}

		// GET: orders
		[HttpGet]
		public IEnumerable<TOrder> Get()
		//public string Get()
		{
			return this.OrdersStorage.toList();
			//return "teste";
		}

		// GET api/<ValuesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST orders/<order data>
		[HttpPost]
		public void Post([FromBody] string value)
		{
			TLocation location = new TLocation {
				address = "Avenida Sumaré",
				number	=  300,
				zip		= "55123000"
			};

			this.OrdersStorage.Add(DateTime.Now, 1, 1, location);
		}

		// PUT orders/<id>
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{

		}

		// DELETE orders/<id>
		[HttpDelete("{id}")]
		public void Delete(int id)
		{

		}
	}
}

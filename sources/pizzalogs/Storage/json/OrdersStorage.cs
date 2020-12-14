using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace pizzalogs
{
	public class JSONOrdersStorage : IOrdersStorage
	{
		List<TOrder> OrdersList;

		public JSONOrdersStorage()
		{
			this.OrdersList = new List<TOrder>();

			if (!File.Exists("orders.json"))
				return;

			var json = JsonSerializer.Deserialize<List<TOrder>>(File.ReadAllText("orders.json"));
			foreach(TOrder order in json)
			{
				this.OrdersList.Add(order);
			}
		}


		public List<TOrder> toList() 
		{
			return this.OrdersList;
		}


		public TOrder Add(DateTime date, int first, int second, TLocation location)
		{
			int		largest;

			largest = 0;
			foreach (TOrder anOrder in this.OrdersList)
			{
				largest = (anOrder.orderId > largest) ? anOrder.orderId : largest;
			}

			TOrder order = new TOrder
			{
				orderId  = largest + 1,
				date	 = date,
				first	 = first,
				second	 = second,
				price	 = 0,
				location = location
			};
			this.OrdersList.Add(order);
			this.UpdateRepository();

			return order;
		}

		public void Remove(int orderID)
		{

		}

		private async void UpdateRepository()
		{
			JsonSerializerOptions options = new JsonSerializerOptions
			{
				WriteIndented = true,
				MaxDepth	  = 6
			};

			using (StreamWriter file = new StreamWriter("orders.json"))
			{
				await file.WriteAsync(JsonSerializer.Serialize(this.OrdersList, options));
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzalogs
{ 
	public interface IOrdersStorage
	{
		public TOrder Add(DateTime date, int first, int second, TLocation location);
		public void Remove(int orderID);
		public List<TOrder> toList();
	}
}

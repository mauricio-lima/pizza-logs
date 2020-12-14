using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzalogs
{
	public class TLocation
	{
		public string	address	{ get; set; }
		public int		number	{ get; set; }
		public string	zip		{ get; set; }
	}


	public class TOrder
	{
		public int		 orderId	{ get; set; }
		public DateTime	 date		{ get; set; }
		public int       first		{ get; set; }
		public int		 second		{ get; set; }
		public decimal	 price		{ get; set; }
		public TLocation location	{ get; set; }
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Entities
{
	public class Property
	{
		public Property()
		{
			this.Values = new List<int>();
		}

		public string Name { get; set; }
		public IEnumerable<int> Values { get; }
		public int DisplayMode { get; set; }
		public int Type { get; set; }
		public double Progress { get; set; }
	}
}

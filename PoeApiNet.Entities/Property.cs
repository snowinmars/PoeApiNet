using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class Property
	{
		public Property()
		{
			this.Values = new List<PropertyValue>();
		}

		public string Name { get; set; }
		public IEnumerable<PropertyValue> Values { get; }
		public int DisplayMode { get; set; }
		public PropertyType Type { get; set; }
		public double Progress { get; set; }
	}
}

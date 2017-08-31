using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public abstract class PropertyValue
	{
		protected PropertyValue(Dimension dimension)
		{
			this.Dimension = dimension;
		}

		public string Value { get; set; }
		public ValueTypes ValueType { get; set; }
		public Dimension Dimension { get; }
	}
}

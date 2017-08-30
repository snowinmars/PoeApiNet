using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class PropertyValue
	{
		public string Value { get; set; }
		public int ValueTypes { get; set; }
		public Dimension Dimension { get; set; }
	}
}

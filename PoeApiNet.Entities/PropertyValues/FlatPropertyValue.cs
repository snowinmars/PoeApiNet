using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class FlatPropertyValue : PropertyValue
	{
		public FlatPropertyValue() : base(Dimension.No)
		{
		}

		public double ValueAsNumber
			=> Double.Parse(this.Value);
	}
}

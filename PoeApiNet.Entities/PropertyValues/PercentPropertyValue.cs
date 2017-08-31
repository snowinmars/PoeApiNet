using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class PercentPropertyValue : PropertyValue
	{
		public PercentPropertyValue() : base(Dimension.Percent)
		{
		}

		public double ValueAsNumber
			=> Double.Parse(this.Value.Replace("%", ""));
	}
}

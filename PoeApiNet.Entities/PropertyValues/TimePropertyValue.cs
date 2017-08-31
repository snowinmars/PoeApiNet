using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class TimePropertyValue : PropertyValue
	{
		public TimePropertyValue() : base(Dimension.Seconds)
		{
		}

		public double ValueAsNumber
			=> Double.Parse(this.Value.Split(' ')[0]); // due to this can be "1.05 sec", "1.05 сек" or whatever
	}
}

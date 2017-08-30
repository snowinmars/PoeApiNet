using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Core
{
	public class InternalProperty
	{
		public string name { get; set; }
		public IList<IList<object>> values { get; set; }
		public int displayMode { get; set; }
		public int type { get; set; }
		public double progress { get; set; }
	}
}

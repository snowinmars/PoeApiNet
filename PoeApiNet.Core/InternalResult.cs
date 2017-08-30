using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Core
{
	public class InternalResult
	{
		public InternalResult()
		{
			this.stashes = new List<InternalStash>();
		}

		public string next_change_id { get; set; }
		public IEnumerable<InternalStash> stashes { get; set; }
	}
}

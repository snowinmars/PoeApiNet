using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Entities
{
	public class Result
	{
		public Result()
		{
			this.Stashes = new List<Stash>();
		}

		public string NextChangeId { get; set; }
		public IList<Stash> Stashes { get; }
	}
}

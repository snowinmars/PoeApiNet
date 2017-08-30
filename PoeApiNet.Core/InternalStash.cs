using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Entities;

namespace PoeApiNet.Core
{
	public class InternalStash
	{
		public InternalStash()
		{
			this.items = new List<InternalItem>();
		}

		public string accountName { get; set; }
		public string lastCharacterName { get; set; }
		public string id { get; set; }
		public string stash { get; set; }
		public string stashType { get; set; }
		public IEnumerable<InternalItem> items { get; set; }
		public bool @public { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Enums;

namespace PoeApiNet.Entities
{
	public class Stash
	{
		public Stash()
		{
			this.Items = new List<Item>();
		}

		public string AccountName { get; set; }
		public string LastCharacterName { get; set; }
		public string Id { get; set; }
		public string StashName { get; set; }
		public StashType StashType { get; set; }
		public IList<Item> Items { get; }
		public bool IsPublic { get; set; }
	}
}

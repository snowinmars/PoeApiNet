using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Core
{
    public class InternalItem
    {
	    public InternalItem()
	    {
			this.socketedItems = new List<InternalItem>();

		    this.sockets = new List<InternalSocket>();

		    this.properties = new List<InternalProperty>();
		    this.additionalProperties = new List<InternalProperty>();

		    this.requirements = new List<InternalRequirement>();
		    this.nextLevelRequirements = new List<InternalRequirement>();

		    this.enchantMods = new List<string>();
		    this.craftedMods = new List<string>();
		    this.flavourText = new List<string>();
		    this.utilityMods = new List<string>();
		    this.explicitMods = new List<string>();
		    this.implicitMods = new List<string>();
		    this.cosmeticMods = new List<string>();
		}

	    public bool verified { get; set; }
	    public int w { get; set; }
	    public int h { get; set; }
	    public int ilvl { get; set; }
	    public string icon { get; set; }
	    public string league { get; set; }
	    public string id { get; set; }
	    public IList<InternalSocket> sockets { get; set; }
	    public string name { get; set; }
	    public string typeLine { get; set; } //
	    public bool identified { get; set; }
	    public bool corrupted { get; set; }
	    public bool lockedToCharacter { get; set; }
	    public string note { get; set; }
	    public IList<InternalProperty> properties { get; set; }
	    public IList<InternalRequirement> requirements { get; set; }
	    public IList<string> explicitMods { get; set; }
	    public IList<string> implicitMods { get; set; }
	    public IList<string> enchantMods { get; set; }
	    public IList<string> craftedMods { get; }
	    public IList<string> flavourText { get; set; }
	    public int frameType { get; set; }
	    public int x { get; set; }
	    public int y { get; set; }
	    public string inventoryId { get; set; }
	    public IList<InternalItem> socketedItems { get; set; }
	    public IList<InternalProperty> additionalProperties { get; }
	    public string secDescrText { get; set; }
	    public string descrText { get; set; }
	    public string artFilename { get; set; }
	    public bool duplicated { get; set; }
	    public int maxStackSize { get; set; }
	    public IList<InternalRequirement> nextLevelRequirements { get; set; }
	    public int stackSize { get; set; }
	    public int talismanTier { get; set; }
	    public IList<string> utilityMods { get; }
	    public bool support { get; set; }
	    public IList<string> cosmeticMods { get; set; }
	    public string prophecyDiffText { get; set; }
	    public string prophecyText { get; set; }
	    public bool isRelic { get; set; }
	}
}

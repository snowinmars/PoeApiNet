using PoeApiNet.Enums;
using System.Collections.Generic;

namespace PoeApiNet.Entities
{
	public class Item
	{
		public Item()
		{
			this.SocketedItems = new List<Item>();

			this.Sockets = new List<Socket>();

			this.Properties = new List<Property>();
			this.AdditionalProperties = new List<Property>();

			this.Requirements = new List<Requirement>();
			this.NextLevelRequirements = new List<Requirement>();

			this.EnchantMods = new List<string>();
			this.CraftedMods = new List<string>();
			this.FlavourText = new List<string>();
			this.UtilityMods = new List<string>();
			this.ExplicitMods = new List<string>();
			this.ImplicitMods = new List<string>();
			this.CosmeticMods = new List<string>();
		}

		public IList<Property> AdditionalProperties { get; }
		public string ArtFilename { get; set; }
		public IList<string> CosmeticMods { get; }
		public IList<string> CraftedMods { get; }
		public string DescriptionText { get; set; }
		public IList<string> EnchantMods { get; }
		public IList<string> ExplicitMods { get; }
		public IList<string> FlavourText { get; }
		public FrameType FrameType { get; set; }
		public int Height { get; set; }
		public string Id { get; set; }
		public string ImageHref { get; set; }
		public IList<string> ImplicitMods { get; }
		public string InventoryId { get; set; }
		public bool IsCorrupted { get; set; }
		public bool IsDuplicated { get; set; }
		public bool IsIdentified { get; set; }
		public bool IsLockedToCharacter { get; set; }
		public bool IsRelic { get; set; }
		public bool IsSupport { get; set; }
		public bool IsVerified { get; set; }
		public int ItemLevel { get; set; }
		public string League { get; set; }
		public int MaxStackSize { get; set; }
		public string Name { get; set; }
		public IList<Requirement> NextLevelRequirements { get; }
		public string Note { get; set; }
		public int PositionX { get; set; }
		public int PositionY { get; set; }
		public IList<Property> Properties { get; }
		public string ProphecyDifficultyText { get; set; }
		public string ProphecyText { get; set; }
		public IList<Requirement> Requirements { get; }
		public string SecondaryDescriptionText { get; set; }
		public IList<Item> SocketedItems { get; }
		public IList<Socket> Sockets { get; }
		public int StackSize { get; set; }
		public int TalismanTier { get; set; }
		public string TypeLine { get; set; }
		public IList<string> UtilityMods { get; }
		public int Weight { get; set; }
	}
}
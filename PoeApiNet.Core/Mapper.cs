using PoeApiNet.Entities;
using PoeApiNet.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PoeApiNet.Core
{
	internal static class Mapper
	{
		internal static Result Map(InternalResult internalResult)
		{
			Result result= new Result();

			result.NextChangeId = internalResult.next_change_id;

			foreach (var internalStash in internalResult.stashes)
			{
				result.Stashes.Add(Map(internalStash));
			}

			return result;
		}

		internal static Stash Map(InternalStash internalStash)
		{
			Stash stash = new Stash();

			stash.AccountName = internalStash.accountName;
			stash.Id = internalStash.id;
			stash.IsPublic = internalStash.@public;
			stash.LastCharacterName = internalStash.lastCharacterName;
			stash.StashName = internalStash.stash;
			stash.StashType = internalStash.stashType.ParseToStashType();

			foreach (var internalItem in internalStash.items)
			{
				stash.Items.Add(Map(internalItem));
			}

			return stash;
		}

		internal static Item Map(InternalItem internalItem)
		{
			Item item = new Item();

			item.ArtFilename = internalItem.artFilename;
			item.DescriptionText = internalItem.descrText;
			item.FrameType = (FrameType)internalItem.frameType;
			item.Height = internalItem.h;
			item.Id = internalItem.id;
			item.ImageHref = internalItem.icon;
			item.InventoryId = internalItem.inventoryId;
			item.IsCorrupted = internalItem.corrupted;
			item.IsDuplicated = internalItem.duplicated;
			item.IsIdentified = internalItem.identified;
			item.IsLockedToCharacter = internalItem.lockedToCharacter;
			item.IsRelic = internalItem.isRelic;
			item.IsSupport = internalItem.support;
			item.IsVerified = internalItem.verified;
			item.ItemLevel = internalItem.ilvl;
			item.League = internalItem.league;
			item.MaxStackSize = internalItem.maxStackSize;
			item.Name = internalItem.name;
			item.Note = internalItem.note;
			item.PositionX = internalItem.x;
			item.PositionY = internalItem.y;
			item.ProphecyDifficultyText = internalItem.prophecyDiffText;
			item.ProphecyText = internalItem.prophecyText;
			item.SecondaryDescriptionText = internalItem.secDescrText;
			item.StackSize = internalItem.stackSize;
			item.TalismanTier = internalItem.talismanTier;
			item.TypeLine = internalItem.typeLine;
			item.Weight = internalItem.w;

			foreach (var additionalProperty in internalItem.additionalProperties)
			{
				item.AdditionalProperties.Add(Map(additionalProperty));
			}

			foreach (var cosmeticMod in internalItem.cosmeticMods)
			{
				item.CosmeticMods.Add(cosmeticMod);
			}

			foreach (var craftedMod in item.CraftedMods)
			{
				item.CraftedMods.Add(craftedMod);
			}

			foreach (var enchantMod in internalItem.enchantMods)
			{
				item.EnchantMods.Add(enchantMod);
			}

			foreach (var explicitMod in internalItem.explicitMods)
			{
				item.ExplicitMods.Add(explicitMod);
			}

			foreach (var flavourText in internalItem.flavourText)
			{
				item.FlavourText.Add(flavourText);
			}

			foreach (var implicitMod in internalItem.implicitMods)
			{
				item.ImplicitMods.Add(implicitMod);
			}

			foreach (var nextLevelRequirement in internalItem.nextLevelRequirements)
			{
				item.NextLevelRequirements.Add(Map(nextLevelRequirement));
			}

			foreach (var property in internalItem.properties)
			{
				item.Properties.Add(Map(property));
			}

			foreach (var requirement in internalItem.requirements)
			{
				item.Requirements.Add(Map(requirement));
			}

			foreach (var socketedItem in internalItem.socketedItems)
			{
				item.SocketedItems.Add(Map(socketedItem));
			}

			foreach (var socket in internalItem.sockets)
			{
				item.Sockets.Add(Map(socket));
			}

			foreach (var utilityMod in internalItem.utilityMods)
			{
				item.UtilityMods.Add(utilityMod);
			}

			return item;
		}

		internal static Requirement Map(InternalRequirement internalRequirement)
		{
			Requirement requirement = new Requirement();

			requirement.DisplayMode = internalRequirement.displayMode;
			requirement.Name = internalRequirement.name;
			requirement.Progress = internalRequirement.progress;
			requirement.Type = (PropertyType)internalRequirement.type;

			foreach (var valuePair in internalRequirement.values)
			{
				requirement.Values.Add(Mapper.Map(valuePair));
			}

			return requirement;
		}

		internal static Property Map(InternalProperty internalProperty)
		{
			Property property = new Property();

			property.DisplayMode = internalProperty.displayMode;
			property.Name = internalProperty.name;
			property.Progress = internalProperty.progress;
			property.Type = (PropertyType)internalProperty.type;

			foreach (var valuePair in internalProperty.values)
			{
				property.Values.Add(Mapper.Map(valuePair));
			}

			return property;
		}

		internal static Socket Map(InternalSocket internalSocket)
		{
			Socket socket = new Socket
			{
				Group = internalSocket.group
			};

			RequirementsAttribute attribute = Mapper.MapRequirementsAttribute(internalSocket.attr);

			socket.RequirementsAttribute = attribute;

			return socket;
		}

		internal static RequirementsAttribute MapRequirementsAttribute(string attr)
		{
			RequirementsAttribute attribute;

			switch (attr)
			{
				case "S":
					attribute = RequirementsAttribute.Strength;
					break;

				case "I":
					attribute = RequirementsAttribute.Intelligence;
					break;

				case "D":
					attribute = RequirementsAttribute.Dexterity;
					break;

				case "W":
					attribute = RequirementsAttribute.White;
					break;

				default:
					throw new ArgumentOutOfRangeException(nameof(attr), attr, null);
			}

			return attribute;
		}

		private static PropertyValue ConstructFlatProperty(string value, int valueType)
		{
			return new FlatPropertyValue
			{
				Value = value,
				ValueType = (ValueTypes)valueType
			};
		}

		private static PropertyValue ConstructPercentProperty(string value, int valueType)
		{
			return new PercentPropertyValue
			{
				Value = value,
				ValueType = (ValueTypes)valueType
			};
		}

		private static PropertyValue ConstructTupleProperty(string value, int valueType)
		{
			return new TuplePropertyValue
			{
				Value = value,
				ValueType = (ValueTypes)valueType
			};
		}

		private static PropertyValue ConstuctTimeProperty(string value, int valueType)
		{
			return new TimePropertyValue
			{
				Value = value,
				ValueType = (ValueTypes)valueType
			};
		}

		private static PropertyValue Map(IList<object> valuePair)
		{
			string value = (string)valuePair[0];
			int valueType = Int32.Parse(valuePair[1].ToString());

			bool isPercentProperty = value.Contains("%");

			if (isPercentProperty)
			{
				return Mapper.ConstructPercentProperty(value, valueType);
			}

			bool isTupleProperty = value.Contains("-") || value.Contains("\\/");

			if (isTupleProperty)
			{
				return Mapper.ConstructTupleProperty(value, valueType);
			}

			bool isTimeProperty = value.Contains(" ");

			if (isTimeProperty)
			{
				return Mapper.ConstuctTimeProperty(value, valueType);
			}

			return Mapper.ConstructFlatProperty(value, valueType);
		}
	}
}
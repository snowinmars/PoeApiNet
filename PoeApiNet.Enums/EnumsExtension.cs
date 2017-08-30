using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Enums
{
	public static class EnumsExtension
	{
		public static string AsString(this StashType type)
		{
			switch (type)
			{
				case StashType.Normal:
					return "Normal";
				case StashType.Premium:
					return "Premium";
				case StashType.Quad:
					return "Quad";
				case StashType.Essence:
					return "Essence";
				case StashType.Currency:
					return "Currency";
				case StashType.Divination:
					return "Divination";
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}

		public static string AsString(this ValueTypes type)
		{
			switch (type)
			{
				case ValueTypes.WhiteOrPhysical:
					return "White, or physical";
				case ValueTypes.BlueForModifiedValue:
					return "Blue for modified value";
				case ValueTypes.Fire:
					return "Fire";
				case ValueTypes.Cold:
					return "Cold";
				case ValueTypes.Lightning:
					return "Lightning";
				case ValueTypes.Chaos:
					return "Chaos";
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}

		public static string AsString(this FrameType type)
		{
			switch (type)
			{
				case FrameType.Normal:
					return "Normal";
				case FrameType.Magic:
					return "Magic";
				case FrameType.Rare:
					return "Rare";
				case FrameType.Unique:
					return "Unique";
				case FrameType.Gem:
					return "Gem";
				case FrameType.Currency:
					return "Currency";
				case FrameType.DivinationCard:
					return "Divination card";
				case FrameType.QuestItem:
					return "Quest item";
				case FrameType.Prophecy:
					return "Prophecy";
				case FrameType.Relic:
					return "Relic";
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}
	}
}

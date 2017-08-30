using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Enums
{
	public enum StashType
	{
		Normal,
		Premium,
		Quad,
		Essence,
		Currency,
		Divination,
	}

	public enum ValueTypes
	{
		WhiteOrPhysical = 0,
		BlueForModifiedValue = 1,
		Fire = 4,
		Cold = 5,
		Lightning = 6,
		Chaos = 7,
	}

	public enum FrameType
	{
		Normal,
		Magic,
		Rare,
		Unique,
		Gem,
		Currency,
		DivinationCard,
		QuestItem,
		Prophecy,
		Relic,
	}

	public enum RequirementsAttribute
	{
		Strength,
		Intelligence,
		Dexterity,
		White,
	}
}

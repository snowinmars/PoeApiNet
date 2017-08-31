using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeApiNet.Enums
{
	public enum Dimension
	{
		No,
		Percent,
		Tuple,
		Seconds,
	}

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

	public enum PropertyType
	{
		Level = 5,
		Quality = 6,
		PhysicalDamage = 9,
		ElementalDamage = 10,
		CriticalStrikeChance = 12,
		AttacksPerSecond = 13,
		WeaponRange = 14,
		ChanceToBlock = 15,
		Armour = 16,
		EvasionRating = 17,
		EnergyShield = 18,
	}
}

using PoeApiNet.Entities;
using PoeApiNet.Enums;
using System;
using System.Collections.Generic;

namespace PoeApiNet.Core
{
	internal static class Mapper
	{
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Entities;
using PoeApiNet.Enums;

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

			foreach (var value in internalProperty.values)
			{
				IList<PropertyValue> list = new List<PropertyValue>();

				for (var i = 0; i < value.Count; i++)
				{
					string l1 = (string)value[0];

					int l3;
					Dimension d;

					if (l1.EndsWith("%"))
					{
						l3 = int.Parse(l1.Substring(0, l1.Length - 1));
						d = Dimension.Percent;
					}

					int l2 = (int) value[1];
				}

			}

			return property;
		}

		internal static Socket Map(InternalSocket internalSocket)
		{
			Socket socket = new Socket();

			socket.Group = internalSocket.group;
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
	}
}

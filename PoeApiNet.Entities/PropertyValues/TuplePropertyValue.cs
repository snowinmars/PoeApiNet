using PoeApiNet.Enums;
using System;

namespace PoeApiNet.Entities
{
	public class TuplePropertyValue : PropertyValue
	{
		public TuplePropertyValue() : base(Dimension.Tuple)
		{
			this.InitSides();
		}

		public FlatPropertyValue LeftPropertyValue { get; set; }

		public FlatPropertyValue RightPropertyValue { get; set; }

		private void InitLeft(string left)
		{
			this.LeftPropertyValue = new FlatPropertyValue
			{
				Value = left,
				ValueType = this.ValueType
			};
		}

		private void InitRight(string right)
		{
			this.RightPropertyValue = new FlatPropertyValue
			{
				Value = right,
				ValueType = this.ValueType
			};
		}

		private void InitSides()
		{
			var (left, right) = this.ParseValues();
			this.InitLeft(left);
			this.InitRight(right);
		}

		private (string left, string right) ParseValues()
		{
			string left = null;
			string right = null;
			if (this.Value.Contains(@"\/"))
			{
				var arr = this.Value.Split(new[] { @"\/" }, StringSplitOptions.RemoveEmptyEntries);

				left = arr[0];
				right = arr[1];
			}

			if (this.Value.Contains("-"))
			{
				var arr = this.Value.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

				left = arr[0];
				right = arr[1];
			}

			if (left == null ||
				right == null)
			{
				throw new InvalidOperationException();
			}

			return (left: left, right: right);
		}
	}
}
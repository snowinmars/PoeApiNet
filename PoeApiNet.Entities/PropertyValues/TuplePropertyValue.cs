using PoeApiNet.Enums;
using System;

namespace PoeApiNet.Entities
{
	public class TuplePropertyValue : PropertyValue
	{
		private FlatPropertyValue leftPropertyValue;
		private FlatPropertyValue rightPropertyValue;

		public TuplePropertyValue() : base(Dimension.Tuple)
		{
		}

		public FlatPropertyValue LeftPropertyValue
		{
			get
			{
				this.EnsureSidesWereCalculated();

				return this.leftPropertyValue;
			}

			set { this.leftPropertyValue = value; }
		}

		public FlatPropertyValue RightPropertyValue
		{
			get
			{
				this.EnsureSidesWereCalculated();
				return this.rightPropertyValue;
			}

			set { this.rightPropertyValue = value; }
		}

		public void RecalculateSides()
		{
			var (left, right) = this.ParseValues();
			this.InitLeft(left);
			this.InitRight(right);
		}

		private void EnsureSidesWereCalculated()
		{
			if (this.leftPropertyValue == null ||
				this.rightPropertyValue == null)
			{
				this.RecalculateSides();
			}
		}

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
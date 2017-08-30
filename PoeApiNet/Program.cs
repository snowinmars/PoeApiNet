using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeApiNet.Core;

namespace PoeApiNet
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = new StashApi();

			var a = s.GetStashes();
		}
	}
}

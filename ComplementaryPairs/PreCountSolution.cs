using System.Collections.Generic;

namespace ComplementaryPairs
{
	public class PreCountSolution
	{
		public int Solve(int target, int[] array)
		{
			var counts = new Dictionary<int, int>();
			foreach (var element in array)
			{
				var complementaryValue = target - element;
				if (!counts.ContainsKey(complementaryValue))
				{
					counts[complementaryValue] = 0;
				}
				
				counts[complementaryValue]++;
			}

			var counter = 0;
			foreach (var element in array)
			{
				if (counts.ContainsKey(element))
				{
					counter += counts[element];
				}
			}

			return counter;
		}
	}
}
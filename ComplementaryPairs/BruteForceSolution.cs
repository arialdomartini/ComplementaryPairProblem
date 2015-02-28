namespace ComplementaryPairs
{
	public class BruteForceSolution
	{
		public int Solve(int target, int[] array)
		{
			var count = 0;
			foreach (var element in array)
			{
				foreach (var other in array)
				{
					if (element + other == target)
					{
						count++;
					}
				}
			}
			return count;
		}
	}
}
 

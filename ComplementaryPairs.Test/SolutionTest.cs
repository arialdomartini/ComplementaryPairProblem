using FluentAssertions;
using NUnit.Framework;

namespace ComplementaryPairs.Test
{
    public class SolutionTest
    {   
	    [TestCase(10, new[]{1,2,3,4}, 0)]
	    [TestCase(20, new[]{10,2,3,4}, 1)]
	    [TestCase(10, new[]{5, 5}, 4)]
	    [TestCase(10, new[]{1, 5, 9}, 3)]
		public void ShouldFindTheNumberOfPairs(int target, int[] array, int expectedNumberOfPairs)
	    {
		    new BruteForceSolution().Solve(target, array).Should().Be(expectedNumberOfPairs);
	    }
    }
}

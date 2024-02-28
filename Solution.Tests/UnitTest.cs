namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new [] { 1, 1, 2 }, new[] { 1, 2 })]
    [InlineData(new [] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
    public void Test(int[] input, int[] expected)
    {
        var count = Solution.RemoveDuplicates(input);

        Assert.Equal(expected.Length, count);
        for (var i = 0; i < count; i++)
        {
            Assert.Equal(expected[i], input[i]);
        }
    }
}
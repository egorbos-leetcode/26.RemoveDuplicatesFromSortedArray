namespace Solution;

public static class Solution
{
    public static int RemoveDuplicates(int[] nums) {
        var prevIdx = -1;
        var uniqueCount = 0;
        var prevValue = -101;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > prevValue)
            {
                prevIdx++;
                uniqueCount++;
                prevValue = nums[i];
                nums[prevIdx] = nums[i];
            }
        }

        return uniqueCount;
    }
}

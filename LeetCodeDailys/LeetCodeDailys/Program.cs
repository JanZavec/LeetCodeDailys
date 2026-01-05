

using LeetCodeDailys;

namespace Leetcode.Dailys;

class Program
{
    private static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int value))
            {
                var array = new int[2];
                array[0] = value;
                array[1] = i;
                return array;
            }
            map[nums[i]] = i;
        }

        return new int[1];
    }


    public static int Main(string[] args)
    {
        var aa = TwoSum([3,4,5,6], 7);
        return 0;
    }
}





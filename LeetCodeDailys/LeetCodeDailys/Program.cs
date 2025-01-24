

namespace Leetcode.Dailys;

class Program
{
    private static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int value))
            {
                return [value, i ];
            }
            map[nums[i]] = i;
        }

        return [];
    }


    public static int Main(string[] args)
    {
        TwoSum([2, 7, 11, 15], 9);
        return 0;
    }
}





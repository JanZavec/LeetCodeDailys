

using Microsoft.VisualBasic;

namespace LeetCodeDailys.Dailies._17._11._2025;

internal class Daily
{
    // more optimal solution exists with only 2 ifs.
    public bool KLengthApart(int[] nums, int k)
    {
        int counter = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (counter == -1 && nums[i] == 1)
            {
                counter = 0;
            } else if (counter != -1 && nums[i] == 1)
            {
                if (counter < k) return false;
                counter = 0;
            }

            if (nums[i] == 0 && counter != -1) counter++;
        }
        return true;
    }
}
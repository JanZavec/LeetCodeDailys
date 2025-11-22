

using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeDailys.Dailies._22._11._2025;

internal class Daily
{
    public int MinimumOperations(int[] nums)
    {
        return nums.Count(x => x % 3 != 0);
    }
}
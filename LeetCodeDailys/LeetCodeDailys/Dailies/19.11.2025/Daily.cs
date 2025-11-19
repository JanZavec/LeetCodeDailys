

using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeDailys.Dailies._19._11._2025;

internal class Daily
{
    public int FindFinalValue(int[] nums, int original)
    {
        int multiplication = original;
       var aa =  nums.ToList();
        aa.Sort();
        foreach (var num in  nums)
        {
            if (num == original) 
            {
                multiplication = 2 * num;
                original = multiplication;
            }
        }
        return multiplication;
    }
}
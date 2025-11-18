

using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeDailys.Dailies._18._11._2025;

internal class Daily
{
    public bool IsOneBitCharacter(int[] bits)
    {
        for (int i = 0; i < bits.Length - 1; i++) 
        {
            if (bits[i] == 0)
            {
                continue;
            }
            else if (bits[i] == 1)
            {
                ++i;
                if (i == bits.Length - 1) return false;
            }
        }
        return true;
    }
}
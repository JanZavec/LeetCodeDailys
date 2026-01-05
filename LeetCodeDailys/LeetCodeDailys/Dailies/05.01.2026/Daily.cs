

using Microsoft.VisualBasic;
using System;

namespace LeetCodeDailys.Dailies._05._01._2026;

public class Daily
{
    public static bool IsAnagram(string s, string t)
    {
        foreach (var charachter in s)
        {
            if (t.Contains(charachter))
            {
                var a = t.IndexOf(charachter);
                var aa = t.ToCharArray();
                aa[a] = '1';
                t = new(aa);
            }
            else
            {
                return false;
            }
        }

        return true || t.All(t => t == '1');
    }
}
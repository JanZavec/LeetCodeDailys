namespace LeetCodeDailys
{
    internal static class Problems
    {
        public static string MergeAlternately(string word1, string word2)
        {
            List<char> letters = [];
            for (int i = 0; i < word1.Length; i++)
            {
                letters.Add(word1[i]);
                if (i < word2.Length)
                    letters.Add(word2[i]);
            }
            if (word2.Length > word1.Length)
            {
                letters.AddRange(word2.Substring(word1.Length));
            }
            return string.Join("",letters);
        }
    }
}

/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> karakterler = new Dictionary<char, int>();
        int maxUzunluk = 0;
        int start = 0;

        for (int end = 0; end < s.Length; end++)
        {
            char c = s[end];

            if (karakterler.ContainsKey(c) && karakterler[c] >= start)
            {
                start = karakterler[c] + 1;
            }

            karakterler[c] = end;

            maxUzunluk = Math.Max(maxUzunluk, end - start + 1);
        }

        return maxUzunluk;
        
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        int total=0;
        if (haystack == null || needle == null||haystack.Length<needle.Length)
        {
            return -1;
        }
        if (haystack==needle)
        {
            return 0;
        }
        for (int i =0;i<haystack.Length-needle.Length+1;i++)
        {
            if (haystack[i]==needle[0])
            {
                for (int j=0;j<needle.Length;j++)
                {
                    if (haystack[i+j]!=needle[j])
                    {
                        break;

                    }
                    else
                    {
                        total++;
                    }
                    
                }
               
                
            }
         if (total==needle.Length)
        {
          return i;
            }
            else
            {
                total=0;
            }
            
        }
        
        return -1;
        
    }
}
// @lc code=end


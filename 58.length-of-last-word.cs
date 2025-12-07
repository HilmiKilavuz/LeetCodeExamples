/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int lenght= s.Length;
        int last= s.Length-1;
        if(lenght==0)
        {
            return 0;
        }
        while (s[last]==' '&&last>0)
        {
            last--;
            
        }   
        if (last<0)
        {
            return 0;
        }else if (last==0)
        {
            return 1;
            
        }
        int first= last-1;
        while (s[first]!= ' '&&first>0)
        {
            first--;
            
        }
        if (first==0&&s[first]!=' ')
        {
         return last-first+1;   
        }
        return last-first;

        
    }
}
// @lc code=end


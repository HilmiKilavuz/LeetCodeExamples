/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        string stringx= x.ToString();
        int lengthx= stringx.Length;
        if(x<0){
            return false;
        }else{
            for(int i=0;i<lengthx;i++){
                if(stringx[i]!=stringx[lengthx-1]){
                    return false;
                }
                lengthx--;
            }
            return true;

        }


    }
}
// @lc code=end


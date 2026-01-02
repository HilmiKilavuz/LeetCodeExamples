/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        string result = "";
        
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0) {
            
            int digitA = 0;
            if (i >= 0) {
                digitA = a[i] - '0'; 
                i--;
            }

            int digitB = 0;
            if (j >= 0) {
                digitB = b[j] - '0';
                j--;
            }

            int currentSum = digitA + digitB + carry;

            int bit = currentSum % 2;
            
            result = bit + result;

            carry = currentSum / 2;
        }

        return result == "" ? "0" : result;
    }
}
// @lc code=end


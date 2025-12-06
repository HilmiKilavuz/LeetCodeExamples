/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start

public class Solution {
    public int MissingNumber(int[] nums) {
        System.Array.Sort(nums);
         if (nums[0] == 1)
            {
                return 0;
            }
        for (int i =0;i<nums.Length-1;i++)
        {
           
            
            if (nums[i]+1!=nums[i+1])
            {
                return nums[i]+1;
                
            }
           
        }
        return nums[nums.Length-1]+1;
        
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null)
        {
            return 0;
        }
        int length=1;
        for (int i=1; i<nums.Length;i++)
        {
            if (nums[i]!=nums[i-1])
            {
                nums[length]=nums[i];
                length++;
            }
            
                           
            
        }
        return length;
    }
}
// @lc code=end


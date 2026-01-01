/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int area=0;
        int left=0;
        int right= height.Length-1;
        while (right>left){
            int newarea=Math.Min(height[left],height[right])*Math.Abs(left-right);
            if (newarea>area)
            {
                area=newarea;
            }
            if (height[right]<height[left])
            {
                right--;

            }
            else
            {
                left++;
            }
        }


        
        return area;
        
    }
}
// @lc code=end


    /*
    * @lc app=leetcode id=35 lang=csharp
    *
    * [35] Search Insert Position
    */

    // @lc code=start
 public class Solution {

    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int left, int right) {
        if (left > right)
            return left;

        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;

        if (nums[mid] > target)
            return BinarySearch(nums, target, left, mid - 1);
        else
            return BinarySearch(nums, target, mid + 1, right);
    }
}

    // @lc code=end


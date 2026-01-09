/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (q==null && p==null)
        {
            return true;
        }
        if ((q!=null && p == null)||(q==null&&p!=null) ||(p.val!=q.val))
        {
            return false;
        }                  
           bool lefltcheck= IsSameTree(p.left,q.left);
           bool rightcheck= IsSameTree(p.right,q.right);

        if (lefltcheck==true && rightcheck == true)
        {
            return true;

        }
        else
        {
            return false;
        }
        
        
    }
}
// @lc code=end


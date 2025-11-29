    /*
    * @lc app=leetcode id=64 lang=csharp
    *
    * [64] Minimum Path Sum
    */

    // @lc code=start
    public class Solution {
    public int MinPathSum(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                
                if (i == 0 && j == 0) continue;

                int left = int.MaxValue;
                int top = int.MaxValue;

                if (j - 1 >= 0) {
                    left = grid[i][j - 1]; 
                }

                if (i - 1 >= 0) {
                    top = grid[i - 1][j]; 
                }

               
                grid[i][j] += Math.Min(left, top);
            }
        }

        return grid[row - 1][col - 1];
    }
}

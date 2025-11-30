/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
using System.Collections.Generic;
public class Solution {
    public bool IsValid(string s) {
        // char türünde veriler tutacak bir yığın oluşturma
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> caracters = new Dictionary<char, char>()
        {
            {')','('},
            {'}','{'},
            {']','['}
        };
        if (s.Length<=0)
        {
            return true;
        }
        if (s.Length%2==1)
        {
            return false;
        }
        foreach (char c in s)
        {
            if (c=='('||c=='['||c=='{')
            {
                stack.Push(c);
            }
            else if(c==')'||c==']'||c=='}')
            {
                 if (stack.Count<=0)
                {
                    return false;
                }
                if (caracters[c]==stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                 break;
                }
                
            }
            
        }

        if (stack.Count<=0)
        {return true;

        }
        return false;

        

    }
}
// @lc code=end


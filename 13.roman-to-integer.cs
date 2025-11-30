/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public Dictionary<char, int> roman_numerals = new Dictionary<char, int>()
    {
    { 'I', 1 },
    { 'V', 5 },
    { 'X',10 },
    { 'L',50 },
    { 'C',100 },
    { 'D',500 },
    { 'M',1000 }
    };

    public int RomanToInt(string s) {
        char[] array = s.ToCharArray();
        int total=0;
        for (int i = 0; i < array.Length; i++){
            
            if(roman_numerals.ContainsKey(array[i])){
                if (i == array.Length - 1) {
                    total += roman_numerals[array[i]];
                    break;
                    }
                if(roman_numerals[array[i]]>=roman_numerals[array[i+1]]){
                    total+=roman_numerals[array[i]];
                }else{
                    total-=roman_numerals[array[i]];

                }
                
            }else{
                Console.WriteLine("karakter roma rakamı değil.");
            }

        } 
        return total;

        
    }
}
// @lc code=end


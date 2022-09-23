/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */
// 暴力法，虽然看起来很蠢，但应该是效率最高的方法
// 3999/3999 cases passed (68 ms)
// Your runtime beats 68.79 % of csharp submissions
// Your memory usage beats 78.55 % of csharp submissions (45.6 MB)
// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
     int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    result += 1;
                    if (i != s.Length - 1)
                        if (s[i + 1] == 'V' || s[i + 1] == 'X') result -= 2;
                    break;
                case 'V':
                    result += 5;
                    break;
                 case 'X':
                    result += 10;
                    if (i != s.Length - 1)
                        if (s[i + 1] == 'L' || s[i + 1] == 'C') result -= 20;
                    break;
                case 'L':
                    result += 50;
                    break;
                case 'C':
                    result += 100;
                    if (i != s.Length - 1)
                        if (s[i + 1] == 'D' || s[i + 1] == 'M') result -= 200;
                    break;
                case 'D':
                    result += 500;
                    break;
                case 'M':
                    result += 1000;
                    break;
            }
        }
        return result;
        }
}
// @lc code=end


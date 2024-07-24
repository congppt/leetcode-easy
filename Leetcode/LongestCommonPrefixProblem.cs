namespace Leetcode
{
    public class LongestCommonPrefixProblem
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;
            for(int i =0; i < strs[0].Length; i++)
            {
                foreach (var str in strs)
                {
                    if (i >= str.Length || str[i] != strs[0][i])
                    {
                        return result;
                    }
                }
                result += strs[0][i];
            }
            return result;
        }
    }
}

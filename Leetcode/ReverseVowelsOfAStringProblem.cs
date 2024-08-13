namespace Leetcode
{
    public class ReverseVowelsOfAStringProblem
    {
        public static string ReverseVowels(string s)
        {
            HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            var left = 0;
            var right = s.Length - 1;
            char[] sLetters = new char[s.Length];
            while (left <= right)
            {
                if (!vowels.Contains(s[left]))
                {
                    sLetters[left] = s[left];
                    left++;
                    continue;
                }
                if (!vowels.Contains(s[right]))
                {
                    sLetters[right] = s[right];
                    right--;
                    continue;
                }
                sLetters[left] = s[right];
                sLetters[right--] = s[left++];
            }
            return new string(sLetters);
        }
    }
}

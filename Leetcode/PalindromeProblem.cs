namespace Leetcode
{
    public class PalindromeProblem
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;
            if (x >= 10 && x % 10 == 0) return false;
            int temp = x;
            int reverse = 0;
            do
            {
                var left = temp % 10;
                reverse = reverse * 10 + left;
                temp /= 10;
            }
            while (temp != 0);
            return reverse == x;
        }
    }
}

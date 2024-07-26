namespace Leetcode
{
    public class SquareRootProblem
    {
        public static int MySqrt(int x)
        {
            if (x <= 1) return x;
            int start = 1;
            int end = x;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                var sqrt = x / mid;
                if (sqrt == mid) return mid;
                if (sqrt < mid)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return end;
        }
    }
}

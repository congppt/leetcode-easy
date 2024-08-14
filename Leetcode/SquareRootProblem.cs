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
                //right bit shift help avoid int overflow
                //shift 1 bit == div by 2
                int mid = (start + end) >> 1;
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

namespace Leetcode
{
    public class ValidParenthesesProblem
    {
        public static bool IsValid(string s)
        {
            Stack<char> opens = [];
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        opens.Push(')');
                        break;
                    case '[':
                        opens.Push(']');
                        break;
                    case '{':
                        opens.Push('}');
                        break;
                    default:
                        if (opens.Count == 0 || c != opens.Pop()) return false;
                        break;
                }
            }
            return opens.Count == 0;
        }
    }
}

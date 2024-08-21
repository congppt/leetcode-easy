using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LicenseKeyFormattingProblem
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            //String builder for better performance
            var builder = new StringBuilder(s.Length);
            var original = s.Replace("-","");
            var startLength = original.Length % k;
            builder.Append(original[..startLength].ToUpper());
            for (int i = startLength; i < original.Length; i += k)
            {
                if (builder.Length > 0) builder.Append('-');
                builder.Append(original.Substring(i, k).ToUpper());
            }
            return builder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ConvertANumberToHexadecimalProblem
    {
        public static string ToHex(int num)
        {
            var hexString = string.Empty;
            uint unum;
            if (num < 0)
                //negative bit representation of int = bit representation of unsigned int of equivalent length
                //ex: -1 (bit representation) == 255 (bit representation)
                unum = (uint)(uint.MaxValue + num + 1);
            else unum = (uint)num;
            while (unum > 0)
            {
                var letterCode = unum % 16;
                if (letterCode < 10) hexString = letterCode + hexString;
                else hexString = (char)(letterCode + 87) + hexString;
                unum = (unum - letterCode) / 16;
            }
            return hexString.Length == 0 ? "0" : hexString;
        }
        static string ToHexBitShift(int num)
        {
            var hexString = string.Empty;
            int count = 0;
            //binary 32 = hex 8
            //converting binary to hex by find letters represent each 4-bit segment
            while (num != 0 && count < 8)
            {
                count++;
                // max value of 4 bit is 15 = F letter
                // & 15 help extract the value of last 4 bit
                var letterCode = num & 15;
                if (letterCode > 9) hexString = (char)(letterCode + 87) + hexString;
                else hexString = letterCode + hexString;
                //remove last 4 bit
                num >>= 4;
            }
            return hexString.Length == 0 ? "0" : hexString;
        }
    }
}

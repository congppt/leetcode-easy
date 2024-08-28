using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class StudentAttendanceRecordIProblem
    {
        public bool CheckRecord(string s)
        {
            int lateCount = 0;
            int absentCount = 0;
            foreach (var c in s)
            {
                switch(c)
                {
                    case 'L':
                        lateCount++;
                        if (lateCount == 3) return false;
                        break;
                    case 'A':
                        lateCount = 0;
                        absentCount++;
                        if (absentCount == 2) return false;
                        break;
                    default:
                        lateCount = 0;
                        break;
                }
            }
            return true;
        }
    }
}

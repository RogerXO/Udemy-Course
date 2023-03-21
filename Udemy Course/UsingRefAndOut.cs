using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Course
{
    internal class UsingRefAndOut
    {
        public static void TripleNoRef(int x)
        {
            x = x * 3;
        }

        public static void TripleWithRef(ref int x)
        {
            x = x * 3;
        }

        public static void TripleWithOut(int x, out int result)
        {
            result = x * 3;
        }
    }
}

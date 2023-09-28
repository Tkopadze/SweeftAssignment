using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Linq;

    public class ArrayUtils
    {
   
        public int NotContains(int[] A)
        {
            int n = A.Length;
            bool[] seen = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] <= n)
                {
                    seen[A[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!seen[i])
                {
                    return i;
                }
            }

            return n + 1;
        }
    }

   


}

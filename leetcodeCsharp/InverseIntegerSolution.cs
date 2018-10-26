using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class InverseIntegerSolution
    {
        public int Reverse(int x)
        {
            int ans = 0;
            List<int> eachDigit = new List<int>();
            bool isPositive = false;
            if(x < 0)
            {
                isPositive = true;
            }
            while(x > 0)
            {
                int onesDigit = x % 10;
                x /= 10;
                eachDigit.Add(onesDigit);
            }
            foreach(int v in eachDigit)
            {
                ans *= 10;
                ans += v;
            }
            if (isPositive)
            {
                ans = -ans;
            }
            return ans;
        }
    }
}

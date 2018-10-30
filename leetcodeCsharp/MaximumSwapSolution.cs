using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class MaximumSwapSolution
    {
        public int setSingleDigit(int num, int dig, int replace)
        {
            int cur = getSingleDigit(num, dig);
            int ans = (int)(num - (int)(cur * Math.Pow(10, dig)));
            ans += replace * (int)(Math.Pow(10, dig));
            return ans;
        }
        public int getSingleDigit(int num, int dig)
        {
            int ans = (int)(num / Math.Pow(10, dig)) % 10;
            return ans;
        }
        public int swapTwoDigits(int num, int loc1, int loc2)
        {
            int a = getSingleDigit(num, loc1);
            int b = getSingleDigit(num, loc2);
            int ans = setSingleDigit(num, loc1, b);
            ans = setSingleDigit(ans, loc2, a);
            return ans;
        }
        public int MaximumSwap(int num)
        {
            int nDigits = 0;
            for (int i = 0; i < 10; ++i) {
                if (num / Math.Pow(10, i) < 1) {
                    nDigits = i;
                    break;
                }
            }
            int curMax = num;

            for (int i = 0; i < nDigits; i++) {
                for (int j = i + 1; j < nDigits; j++) {
                    curMax = Math.Max(curMax, swapTwoDigits(num, i, j));
                }
            }

            return curMax;
        }
    }
}

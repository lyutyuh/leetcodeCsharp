using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class ThreeSumClosestSolution
    {
        class MyCOMP : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return a.CompareTo(b);
            }
        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            int ret_diff = 99999999;
            List<int> sortedNums = nums.OrderBy(x => x).ToList<int>();
            for (int iter1 = 0; iter1 < sortedNums.Count; ++iter1)
            {
                if (iter1 > 0 && sortedNums[iter1] == sortedNums[iter1 - 1])
                {
                    continue;
                }

                for (int iter2 = iter1 + 1; iter2 < sortedNums.Count; ++iter2)
                {
                    if (iter2 > iter1 + 1 && sortedNums[iter2] == sortedNums[iter2 - 1])
                    {
                        continue;
                    }

                    int targ = target - sortedNums[iter1] - sortedNums[iter2];
                    int targetIndex = sortedNums.BinarySearch(iter2 + 1, sortedNums.Count - (iter2 + 1), targ, new MyCOMP());
                    if (targetIndex > 0)
                    {
                        ret_diff = 0;
                        return 0;
                    }
                    else
                    {
                        targetIndex = ~targetIndex;
                        int tmp_diff = 0;
                        if (targetIndex == iter2+1)
                        {
                            tmp_diff = Math.Abs(targ - sortedNums[1]);
                            ret_diff = Math.Min(ret_diff, tmp_diff);
                            continue;
                        }
                        if(targetIndex == sortedNums.Count)
                        {
                            tmp_diff = Math.Abs(targ - sortedNums.Last());
                            ret_diff = Math.Min(ret_diff, tmp_diff);
                            continue;
                        }

                        tmp_diff = Math.Abs(targ - sortedNums[targetIndex]);
                        tmp_diff = Math.Min(tmp_diff, targ - sortedNums[targetIndex - 1]);
                        ret_diff = Math.Min(ret_diff, tmp_diff);
                        Console.WriteLine("{0},{1},{2}", sortedNums[iter1], sortedNums[iter2], ret_diff);
                        continue;

                    }
                }
            }
            return ret_diff;
        }
    }
}

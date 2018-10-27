using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tryCSharp
{
    class ThreeSumSolution
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        class MyCOMP : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return a.CompareTo(b);
            }
        }
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> ans = new List<IList<int>>();
            List<int> sortedNums = nums.OrderBy(x => x).ToList<int>();
            for(int iter1 = 0; iter1 < sortedNums.Count; ++iter1)
            {
                if(iter1 > 0 && sortedNums[iter1] == sortedNums[iter1 - 1])
                {
                    continue;
                }

                for(int iter2 = iter1 + 1; iter2 < sortedNums.Count; ++iter2)
                {
                    if (iter2 > iter1 + 1 && sortedNums[iter2] == sortedNums[iter2 - 1])
                    {
                        continue;
                    }

                    int target = 0 - sortedNums[iter1] - sortedNums[iter2];
                    int targetIndex = sortedNums.BinarySearch(iter2+1, sortedNums.Count, target, new MyCOMP());
                    if (targetIndex > 0)
                    {
                        ans.Add(new List<int>(new int []{
                            sortedNums[iter1],
                            sortedNums[iter2],
                            sortedNums[targetIndex]}));
                    }
                    else
                    {
                        targetIndex = ~targetIndex;
                        if(targetIndex == 0)
                        {
                            break;
                        }
                    }
                }
            }
            return ans;
        }
    }
}

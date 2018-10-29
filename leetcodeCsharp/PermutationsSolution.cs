using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class PermutationsSolution
    {
        private IList<IList<int>> RecurPermutation(List<int> nums)
        {
            List<IList<int>> returned = new List<IList<int>>();
            if(nums.Count == 1) {
                returned.Add(nums);
                return returned;
            }
            List<int> newNums = new List<int>(nums);            
            int nElements = newNums.Count;
            for(int i = 0; i < nElements; ++i) {
                int tmp = newNums[0];
                newNums[0] = newNums[i];
                newNums[i] = tmp;

                Console.WriteLine(tmp);
                Console.WriteLine(String.Join(",", newNums));

                IList<IList<int>> tmpList = RecurPermutation(newNums.Skip(1).ToList());
                foreach(List<int> iterList in tmpList) {
                    iterList.Reverse();
                    iterList.Add(newNums[0]);
                    iterList.Reverse();
                }
                returned = returned.Concat(tmpList).ToList();

                newNums[i] = newNums[0];
                newNums[0] = tmp;
            }
            return returned;
        }

        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> ans = RecurPermutation(nums.ToList());
            return ans;
        }
    }
}

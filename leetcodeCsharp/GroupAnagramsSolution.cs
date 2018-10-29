using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class GroupAnagramsSolution
    {
        private int indexInList(IDictionary<string, int> myDict, string myString)
        {
            string sortedIterString = String.Concat(myString.OrderBy(x => x).ToArray());
            // myString.OrderBy() returns an iterable of chars...
            Console.WriteLine(sortedIterString);
            if (myDict.ContainsKey(sortedIterString)) {
                return myDict[sortedIterString];
            }
            else {
                int tmp = myDict.Count;
                myDict.Add(sortedIterString, myDict.Count);
                return tmp;
            }
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> ans = new List<IList<string>>();
            Dictionary<string, int> mapper = new Dictionary<string, int>();
            foreach (string iterString in strs) {
                int indinlist = indexInList(mapper, iterString);
                if (indinlist == ans.Count) {
                    List<string> newlist = new List<string> { iterString };
                    ans.Add(newlist);
                }
                else {
                    ans[indinlist].Add(iterString);
                }
            }

            return ans;
        }
    }
}

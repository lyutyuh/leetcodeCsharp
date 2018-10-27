using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tryCSharp
{
    class LongestSubstring
    {

        static public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();
            int ans = 0;
            int currentLSSBeginInd = 0; // current beginning index of Longest Substring

            for(int iterInd = 0;iterInd < s.Length; ++iterInd)
            {
                char c = s[iterInd];
                if (myDict.ContainsKey(c))
                {
                    int cutHere = myDict[c];
                    for(; currentLSSBeginInd <= cutHere; ++currentLSSBeginInd)
                    {
                        myDict.Remove(s[currentLSSBeginInd]);
                    }
                }
                myDict.Add(c, iterInd);
                ans = ans > myDict.Count ? ans : myDict.Count;
            }
            return ans;
        }
        
        
    }
}

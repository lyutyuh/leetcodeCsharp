using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tryCSharp
{
    class ValidParenthesisSolution
    {
        public bool IsValid(string s)
        {
            Dictionary<char, int> lefts = new Dictionary<char, int>();
            Dictionary<char, int> rights = new Dictionary<char, int>();
            lefts.Add('[', 1); lefts.Add('(', 2); lefts.Add('{', 3);
            rights.Add(']', 1); rights.Add(')', 2); rights.Add('}', 3);
            Stack symbolsStack = new Stack();

            foreach(char c in s)
            {
                if (lefts.ContainsKey(c))
                {
                    symbolsStack.Push(c);                    
                }
                else
                {
                    if(symbolsStack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char topChar = (char)symbolsStack.Pop();
                        if(lefts[topChar] != rights[c])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;

        }
    }
}

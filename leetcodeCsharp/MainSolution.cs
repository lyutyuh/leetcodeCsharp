using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class MainSolution
    {
        static void Main()
        {
            MaximumSwapSolution mss = new MaximumSwapSolution();
            Console.WriteLine(mss.swapTwoDigits(1234567, 3, 6));
            Console.WriteLine("Main() finished execution. Press any key to continue.");
            Console.ReadKey();
            return;
        }
    }
}

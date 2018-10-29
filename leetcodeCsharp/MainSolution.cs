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
            PermutationsSolution ps = new PermutationsSolution();
            IList<IList<int>> toPrint = ps.Permute(new int[3] { 1,2,3});
            Console.WriteLine(toPrint);
            Console.WriteLine("Main() finished execution. Press any key to continue.");
            Console.ReadKey();
            return;
        }
    }
}

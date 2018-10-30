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
            RotateImageSolution ris = new RotateImageSolution();
            ris.Rotate(new int[,] { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } });

            Console.WriteLine("Main() finished execution. Press any key to continue.");
            Console.ReadKey();
            return;
        }
    }
}

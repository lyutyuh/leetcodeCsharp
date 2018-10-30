using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class RotateImageSolution
    {
        private const double epsilon = 1e-6;
        private int toNearestInt(double x)
        {
            if (x > 0)
                return (int)(x + epsilon);
            else
                return (int)(x - epsilon);

        }
        private void RotateOneElement(int x, int y, double mid, int[,] matrix)
        {
            int prev = matrix[x, y];
            double fx = x-mid, fy = y-mid;
            int tmp;
            for (int i = 0; i < 4; ++i) {
                double nextx, nexty;
                nextx = fy;
                nexty = -fx;
                tmp = prev;
                prev = matrix[toNearestInt(nextx + mid), toNearestInt(nexty + mid)];
                matrix[toNearestInt(nextx + mid), toNearestInt(nexty + mid)] = tmp;
                fx = nextx;
                fy = nexty;
            }

        }
        public void Rotate(int[,] matrix)
        {
            double mid = (double)(matrix.GetLength(0) - 1) / 2.0;
            int sz = toNearestInt(mid) + matrix.GetLength(0) % 2;
            for (int i = 0; i <= toNearestInt(mid); i++) {
                for (int j = i; j <= toNearestInt(mid); j++) {
                    RotateOneElement(i, j, mid, matrix);
                }
            }
            return;
        }
    }
}

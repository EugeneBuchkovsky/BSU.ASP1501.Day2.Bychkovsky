using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BSU.ASP1501.Day2.Bychkovsky.Task4
{
    public static class LogicEuclidMethod
    {
        /// <summary>
        /// Euclid's algorithm for 2 arguments.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GCD(int m, int n)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            while (n != 0)
                n = m % (m = n);
            time.Stop();
            return Math.Abs(m);
        }

        /// <summary>
        /// Euclid's algorithm for 3 arguments.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int GCD(int m, int n, int k)
        {
            return GCD(GCD(m,n), k);
        }

        /// <summary>
        /// Euclid's algorithm for n arguments.
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static int GCD(params int[] arrayInt)
        {
            int fTemp = 0, temp = GCD(arrayInt[0],arrayInt[1]);
            for (int i = 1; i < arrayInt.Length - 1; i++)
            {
                if (temp == 1)
                    return temp;
                fTemp = GCD(temp, arrayInt[i]);
                temp = fTemp;
            }
            return temp;
        }

        /// <summary>
        /// Binary Euclid's algorithm for 2 arguments.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int BinaryAlgorithm(int m, int n)
        {
            if (m == n)
                return m;
            if (m == 0)
                return m;
            if (n == 0)
                return n;
            if (m == 1 || n == 1)
                return 1;
            if ((m % 2 == 0) && (n % 2 == 0))
                return 2 * BinaryAlgorithm(m / 2, n / 2);
            if ((m % 2 == 0) && (n % 2 == 1))
                return BinaryAlgorithm(m / 2, n);
            if ((m % 2 == 1) && (n % 2 == 0))
                return BinaryAlgorithm(m, n / 2);
            return BinaryAlgorithm(n, Math.Abs(m - n));
        }

        /// <summary>
        /// Binary Euclid's algorithm for 3 arguments.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int BinaryAlgorithm(int m, int n, int k)
        {
            return BinaryAlgorithm(BinaryAlgorithm(m, n), k);
        }

        /// <summary>
        /// Binary Euclid's algorithm for n arguments.
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static int BinaryAlgorithm(params int[] arrayInt)
        {
            int fTemp = 0, temp = BinaryAlgorithm(arrayInt[0], arrayInt[1]);
            for (int i = 1; i < arrayInt.Length - 1; i++)
            {
                if (temp == 1)
                    return temp;
                fTemp = BinaryAlgorithm(temp, arrayInt[i]);
                temp = fTemp;
            }
            return temp;
        }
    }
}

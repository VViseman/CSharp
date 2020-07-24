/*
using System;

namespace ModInverseTest
{
    class Program
    {
        public static void ExtendedEuclid(int a, int b)
        {
            var x = 0;
            var y = 1;
            var gcd = b;

            var prev_x = 1;
            var prev_y = 0;
            var prev_gcd = a;

            var temp = 0;

            while (gcd > 0)
            {
                int quotient = prev_gcd / gcd;

                temp = x;
                x = prev_x - quotient * temp;
                prev_x = temp;

                temp = y;
                y = prev_y - quotient * temp;
                prev_y = temp;

                temp = gcd;
                gcd = prev_gcd - quotient * temp;
                prev_gcd = temp;
            }

            Console.WriteLine(string.Format("{0}*{1} + {2}*{3} = gcd({0},{2}) = {4}",
                a,
                prev_x,
                b,
                prev_y,
                prev_gcd));
        }

        static void Main(string[] args)
        {
            ExtendedEuclid(1071, 1029);
        }
    }
}

*/

//mcs -r:System.Numerics find-intger-pair.cs
//でコンパイル

using System;
using System.Numerics;

namespace ModInverseTest
{
    class Program
    {
        /*
                public static BigInteger ModInverse(BigInteger a, BigInteger m)
                {
                    if (a < 0)
                    {
                        a = BigInteger.ModPow(a, 1, m) + m;
                    }

                    BigInteger x = 0, y = 1, gcd = m;
                    BigInteger px = 1, py = 0, pgcd = a;
                    BigInteger temp = 0;

                    while (gcd > 0)
                    {
                        BigInteger quotient = pgcd / gcd;

                        temp = x;
                        x = px - quotient * temp;
                        px = temp;

                        temp = y;
                        y = py - quotient * temp;
                        py = temp;

                        temp = gcd;
                        gcd = pgcd - quotient * temp;
                        pgcd = temp;
                    }

                    return px;
                }
        */
        public static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            return BigInteger.ModPow(a, m - 2, m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a =  1, m = 11, mod_inverse = " + ModInverse(1 , 11));
            Console.WriteLine("a =  2, m = 11, mod_inverse = " + ModInverse(2 , 11));
            Console.WriteLine("a =  3, m = 11, mod_inverse = " + ModInverse(3 , 11));
            Console.WriteLine("a =  4, m = 11, mod_inverse = " + ModInverse(4 , 11));
            Console.WriteLine("a =  5, m = 11, mod_inverse = " + ModInverse(5 , 11));
            Console.WriteLine("a =  6, m = 11, mod_inverse = " + ModInverse(6 , 11));
            Console.WriteLine("a =  7, m = 11, mod_inverse = " + ModInverse(7 , 11));
            Console.WriteLine("a =  8, m = 11, mod_inverse = " + ModInverse(8 , 11));
            Console.WriteLine("a =  9, m = 11, mod_inverse = " + ModInverse(9 , 11));
            Console.WriteLine("a = 10, m = 11, mod_inverse = " + ModInverse(10, 11));
            Console.WriteLine("a = 11, m = 11, mod_inverse = " + ModInverse(11, 11));
        }
    }
}
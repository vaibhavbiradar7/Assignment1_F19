using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            Console.WriteLine("");

            int n2 = 7;
            printSeries(n2);
            Console.WriteLine("");
            


            int n3 = 5;
            printTriangle(n3);
            Console.WriteLine("");
            
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 0, 0 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine("");
            

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 9, 10 };
            int r5 = getLargestCommonSubArray(arr1, arr2);
           

            Console.WriteLine("");
            
            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {
                    if (isSelfDividing(i))
                    { Console.Write(i + " , "); }

                }

                bool isSelfDividing(int t)
                {
                    int z = t;
                    while (z > 0)
                    {
                        int d = z % 10;
                        if (d == 0 || t % d != 0)
                            return false;

                        z /= 10;
                    }
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                {
                    int l = 1;
                    for (int i = 1; i <= n; i++)
                    {


                        for (int j = 1; j <= i; j++)

                        {

                            if (l <= n)
                                Console.Write(" " + i + " ,");
                            l = l + 1;

                        }

                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                int s = 1;
                for (int row = 1; row <= n; row++)
                {
                    for (int i = 1; i <= s; i++)

                        Console.Write(" ");
                    s++;


                    for (int col = 0; col <= 2 * (5 - row); col++)


                        Console.Write("*");



                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }


        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int f = 0;

                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {

                        if (J[i] == S[j])
                        {
                            f = f + 1;
                        }


                    }

                }
                return f;
            }


            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                int[] k = new int[] { };
                int lenJ = a.Length;
                int lenS = b.Length;
                int l = 0;
                for (int i = 0; i < lenJ; i++)
                {
                    for (int j = 0; j < lenS; j++)
                    {
                        if (a[i] == b[j])
                        {
                            k[l] = b[i];
                            l++;
                        }
                    }
                }

                for (int i = 0; i < a.Length + b.Length; i++)
                {
                    Console.Write(k[i]);
                }
                int lenK = k.Length;
                for (int i = 0; i < lenK - 1; i++)
                {
                    if (k[i + 1] - k[i] == 1)
                    {

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return 0;
            // return the actual array
        }


        public static void solvePuzzle()
        {
            try
            {

            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}


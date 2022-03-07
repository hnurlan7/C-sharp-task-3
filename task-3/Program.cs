using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// task 1
            //Console.WriteLine(Divider(-7, 2));

            //// task 2
            Console.WriteLine(Repeat("Ha!", 5));

            //// task 3
            //Console.WriteLine(Sum(17, 34, 3, -24, 5.75));

            //// task 4 

            ////Circle Area
            //Console.WriteLine(CircleArea(4)); 

            //// Rectangular Area
            //Console.WriteLine(RectangularArea(6, 8));

            ////Triangle Circle Area
            //Console.WriteLine(TriangleCircleArea(3, 5, 6, 7));
        }
        #region task 1
        //static double Divider(double a, double b)
        //{
        //    return a / b;
        //}
        #endregion

        #region task 2
        static string Repeat(string word, int count)
        {
            string sum = "";
            if (count > 0)
            {
                int i = 0;
                while (i < count)
                {
                    sum += word;
                    i++;
                }
            }
            return sum;

        }
        #endregion

        #region task 3

        //static double Sum(params double[] nums)
        //{
        //    double total = 0;
        //    foreach (double item in nums)
        //    {
        //        total += item;
        //    }
        //    return total;
        //}

        #endregion

        #region task 4

        //// Circle Area
        //static int CircleArea(int r)
        //{
        //    int s = 0;
        //    if (r > 0)
        //    {
        //        int p = 3;
        //        s = p * r * r;
        //    }
        //    return s;
        //}

        //// Rectangular Area
        //static int RectangularArea (int a, int b)
        //{
        //    int s = 0;
        //    if (a > 0 && b > 0)
        //    {
        //        s = a * b;
        //    }
        //    return s;
        //}

        //// Triangle Circle Area
        //static int TriangleCircleArea(int a, int b, int c, int r)
        //{
        //    int s = 0, p;
        //    if (a > 0 && b > 0 && c > 0 && r > 0)
        //    {
        //        p = (a + b + c) / 2;
        //        s = p * r;
        //    }
        //    return s;
        //}
        #endregion
    }
}

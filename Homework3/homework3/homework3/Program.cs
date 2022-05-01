using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //// first exercise
            //int x =  Convert.ToInt32(Console.ReadLine());
            //if (x % 10 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region 2
            //Console.WriteLine("insert X");
            //var X = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("insert Y");
            //var Y = Convert.ToDecimal(Console.ReadLine());
            //// addition
            //Console.WriteLine($"x + y = {X + Y}");
            //// subtraction
            //if (X > Y)
            //{
            //    Console.WriteLine($"x - y = {X - Y}");
            //}
            //else
            //{
            //    Console.WriteLine($"y - x = {Y - X}");
            //}
            //// multiplication
            //Console.WriteLine($"x * y = {X * Y}");
            //// division
            //if (X > Y)
            //{
            //    if (Y == 0)
            //    {
            //        Console.WriteLine("Not Allowed To Divide By Zero");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"x / y = {X / Y}");
            //    }
            //}
            //else
            //{
            //    if (X == 0)
            //    {
            //        Console.WriteLine("Not Allowed To Divide By Zero");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"y / x = {Y / X}");
            //    }

            //}
            #endregion
            #region 3
            var X = Convert.ToDecimal(Console.ReadLine());
            var Y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"Y = {Y}");
            var C = X;
            X = Y;
            Y = C;
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"Y = {Y}");
            
            #endregion
            #region 4
            //var a = Convert.ToDecimal(Console.ReadLine());
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"{a} * {i} = {a * i}");
            //}
            #endregion
            #region 5
            //var b = Convert.ToDecimal(Console.ReadLine());
            //for (int i = 1; i < b; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            //    } 
            //}
            #endregion


        }
    }
}

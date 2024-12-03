using System.Numerics;

namespace Lab5
{

    class Math
    {
        public static int Add(int x, int y)
        {
            return x + y;

        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int postiveSubtract(int x, int y)
        {
            if (x > y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            };
        }
            public static int Multiply(int a, int b) { return a * b; }
        public static double? Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("can't divide by zero");
                return null;
            }
            else
            {
                return a / b;
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine(Math.Add(1, 2));
            Console.WriteLine(Math.Subtract(10, 4));
            Console.WriteLine(Math.Subtract(1, 6));
            Console.WriteLine(Math.Multiply(12, 3));
            Console.WriteLine(Math.Divide(0,0));

        }
    }
    }

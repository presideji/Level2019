using System;

namespace First2019Console
{
    public class Calculator
    {
        private static int _numOne;
        private static int _numTwo;
        public static void Addition(int a, int b)
        {
            _numOne = a;
            _numTwo = b;
            var result = a + b;
            Console.WriteLine($"The sum of {a} & {b} is {result}");
        }

        public static void Multiplication(int c, int d)
        {
            _numOne = c;
            _numTwo = d;
            var result = c*d;
            //Console.WriteLine($"{c} times {d} = {result}");
        }

        public static int Subtraction(int e, int f)
        {
            _numOne = e;
            _numTwo = f;
            var result = e - f;
            return result;
        }

        public static void Division()
        {
            var num = Subtraction(5, 3);
            var Result = num * 50;
            Console.WriteLine(Result);
        }

    }
}
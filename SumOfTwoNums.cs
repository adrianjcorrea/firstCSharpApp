//This Class sums up two numbers.
using System;

namespace SumOfTwo
{
    class SumTheNumbers
    {
        public int SumTwoInt(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 888;
            //Create instance of SumTwoInt function.
            SumTheNumbers ins = new SumTheNumbers();
            Console.WriteLine(ins.SumTwoInt(num1, num2));
            Console.ReadLine();
        }
    }
}
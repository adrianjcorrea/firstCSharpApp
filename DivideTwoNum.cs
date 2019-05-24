//This Class divides two numbers.
using System;

namespace DivisionOfTwo
{
    class DivideTheNumbers
    {
        public int DivideTwoInt(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 888;
            //Create instance of SumTwoInt function.
            DivideTheNumbers ins = new DivideTheNumbers();
            Console.WriteLine(ins.DivideTwoInt(num1, num2));
            Console.ReadLine();
        }
    }
}
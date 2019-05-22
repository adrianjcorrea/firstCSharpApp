//Function is supposed to greet by saying hello.
//printing yourName on a separate line.
using System;

namespace CalculatorApplication
{
    class GreetYourSelf
    {
        static void Main(string[] args)
        {
            string greet = "Hello";
            string name = "Jose Adrian Correa mendez";
            //This(space) defines a break for a new line.
            string space = "\n";
            Console.WriteLine("{0}{1}{2}", greet, space, name);
            Console.ReadLine();
        }
    }
}
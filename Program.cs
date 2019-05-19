using System;

namespace helloWorld
{
    class Program
    {
        string n(string a, string b)
        {
          if(a.Length > b.Length){
              return a;
          } else {
              return b;
          }
        }
        static void Main(string[] args)
        {  

            string greet = "hello there";

            string dismis = "Good Bye";

            string le;

            int age = 27;

            Program nice = new Program();
              
            le = nice.n(greet, dismis);
            Console.WriteLine(le + " I'm " + age);


        }
    }
}


using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePoints();
        }

        static void UseOutModifier()
        {
            try                                               //
            {
                var num = int.Parse("abc");
            }                                                     
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }                                                  // here the method will throw an exception


            int number;
            var result = int.TryParse("abc", out number);      // here tryparse is used which returns boolean
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");        // here the exception would not be thrown instead this else will run

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));  //because of the params method we can
                                                                             //declare the numbers like this also
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);             // here we are point overload method point.Move(new Point(40,60))
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}

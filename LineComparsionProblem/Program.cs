using System;

namespace LineComparsionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Computation Program");
            LineCalculating lineOne = new LineCalculating(5.0, 3.0, 1.0, 6.0);
            double lengthOne = lineOne.LengthCalculate();
            Console.WriteLine("The length of the first line is {0}", lengthOne);
            LineCalculating lineTwo = new LineCalculating(7.0, 2.0, 3.0, 4.0);
            double lengthTwo = lineTwo.LengthCalculate();
            Console.WriteLine("The length of the second line is {0}", lengthTwo);
            lineTwo.Check(lengthOne, lengthTwo);
        }
    }
}

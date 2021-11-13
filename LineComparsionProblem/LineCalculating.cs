using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparsionProblem
{
    // UseCase 2: Checking Eqality of Lines

    class LineCalculating
    {
        double xOnePoint, xTwoPoint, yOnePoint, yTwoPoint;
        public LineCalculating(double xOnePoint, double xTwoPoint, double yOnePoint, double yTwoPoint)
        {
            this.xOnePoint = xOnePoint;
            this.xTwoPoint = xTwoPoint;
            this.yOnePoint = yOnePoint;
            this.yTwoPoint = yTwoPoint;
        }
        public double LengthCalculate()
        {
            double result = Math.Sqrt(Math.Pow(this.xTwoPoint - this.xOnePoint, 2) + Math.Pow(this.yTwoPoint - this.yOnePoint, 2));
            return result;
        }
        public void Check(double lengthOne, double lengthTwo)
        {
            if (lengthOne.Equals(lengthTwo))
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparsionProblem
{
    // UseCase 1: Calculating Length

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
    }
}

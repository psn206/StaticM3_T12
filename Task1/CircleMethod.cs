using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class CircleMethod
    {

        public static double GetLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static string BelongTo(double radius, double x, double y)
        {
            double r = Math.Sqrt(x * x + y * y);
            return radius >= r ? "Точка пренадлежит окружности" : "Точка не пренадлежит окружности";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности с координатами центра (0, 0)");
            Console.Write("R=");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина окуржности: {CircleMethod.GetLength(radius):f} " +
                $"Площадь:{CircleMethod.GetArea(radius):f}");

            Console.WriteLine("Введите координаты точки проверяющий принадлежность к кругу");
            Console.Write("X=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y=");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CircleMethod.BelongTo(radius, x, y));
            Console.ReadKey();
        }
    }
}

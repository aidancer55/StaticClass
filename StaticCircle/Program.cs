using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle.Length();
            Triangle.Square();
            Triangle.Point();
            Console.ReadLine();
        }
        static class Triangle
        {
            static double rad = Convert.ToDouble(Console.ReadLine());
            static double length;
            static double square;
            static double x0 = Convert.ToDouble(Console.ReadLine());
            static double y0 = Convert.ToDouble(Console.ReadLine());
            static double x1 = Convert.ToDouble(Console.ReadLine());
            static double y1 = Convert.ToDouble(Console.ReadLine());
            static public void Length()
            {
                length = 2 * Math.PI * rad;
                length = Math.Round(length, 2);
                Console.WriteLine("Радиус окружности = {0}см", rad);
                Console.WriteLine("Длина окружности = {0}см", length);
                Console.WriteLine();
            }
            static public void Square()
            {
                square = Math.PI * Math.Pow(rad, 2);
                square = Math.Round(square, 2);
                Console.WriteLine("Радиус круга = {0}см", rad);
                Console.WriteLine("Площадь круга = {0}см2", square);
                Console.WriteLine();
            }
            static public void Point()
            {
                Console.WriteLine("Координаты центра окружности ({0}; {1})", x0, y0);
                Console.WriteLine("Координаты точки ({0}; {1})", x1, y1);
                if (x1 - x0 < 0)
                {
                    x1 = Math.Abs(x1 - x0);
                }
                else if (y1 - y0 < 0)
                {
                    y1 = Math.Abs(y1 - y0);
                }
                double a = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                if (a == rad || a < rad)
                {
                    Console.WriteLine("Точка принадлежит кругу");
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит кругу");
                }
                Console.ReadKey();
            }

        }
    }
}

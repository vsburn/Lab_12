using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    #region Задача
    /*
     * Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
      - метод, определяющий длину окружности по заданному радиусу;
      - метод, определяющий площадь круга по заданному радиусу;
      - метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите какие действия необходимо выполнить:");
            Console.WriteLine("1 - найти длину окружности");
            Console.WriteLine("2 - найти площадь круга");
            Console.WriteLine("3 - проверить принадлежность точки кругу");
            Console.WriteLine("0 - выход");
            string s;
            do
            {
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        {
                            Console.Write("радиус окружности: ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Длина окружности: {Circle.Length(r)}");
                            Console.WriteLine("\nВыберите необходимое действие из указанных выше (1 | 2 | 3 | 0): ");
                            break;
                        }
                    case "2":
                        {
                            Console.Write("радиус окружности: ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Площадь круга: {Circle.Sq(r)}");
                            Console.WriteLine("\nВыберите необходимое действие из указанных выше (1 | 2 | 3 | 0): ");
                            break;
                        }
                    case "3":
                        {
                            double x, y, r, x0, y0;
                            Console.Write("Координата точки х: ");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Координата точки y: ");
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Координата центра круга x0: ");
                            x0 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Координата центра круга y0: ");
                            y0 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Радиус круга круга r: ");
                            r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine((Circle.PointIn(x, y, r, x0, y0)) ? "Точка лежит внутри круга" : "Точка за пределами круга");
                            Console.WriteLine("\nВыберите необходимое действие из указанных выше (1 | 2 | 3 | 0): ");
                            break;
                        }
                    default:
                        break;
                }
            } while (s != "0");

        }
    }
    public static class Circle
    {
        public static double Length(double r)
        {
            return 2 * Math.PI * r;
        }
        internal static double Sq(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static bool PointIn(double x, double y, double r, double x0, double y0)
        {
            return (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2)) <= Math.Pow(r, 2);
        }
    }
}

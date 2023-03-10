using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cylinder's height:");
            string areaquestion = Console.ReadLine();
            Console.WriteLine("Enter the cylinder's radius:");
            string radiusquestion = Console.ReadLine();

            int area = Convert.ToInt32(areaquestion);
            int radius = Convert.ToInt32(radiusquestion);
            double value = Math.PI * Math.Pow(radius, 2) * area;

            Console.WriteLine($"The cylinder's volume is: {value}");

            double s = 2 * Math.PI * radius * (radius + area);

            Console.WriteLine($"The cylinder's surface area is: {s}");
        }
    }
}
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

            float pi = 3.1415926f;
            float V = pi * radius * radius * area;

            Console.WriteLine($"The cylinder's volume is: {V}");
        }
    }
}
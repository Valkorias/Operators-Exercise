using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");

                Console.WriteLine("What is the radius of your circle?");


                Console.Write("Enter Radius: ");
                double Radius = Convert.ToDouble(Console.ReadLine());
                double Area = Math.PI * Radius * Radius;
                Console.WriteLine("Area of circle: " + Area);
                Console.ReadKey();

            }
        }
    }
}
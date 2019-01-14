using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Welcome to Grand Circus's Room Detail Generator!");
                Console.Write("Please Enter the Length of the Room: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Please Enter the Width of the Room: ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + length * width);
                double perimeter = length * 2 + width * 2;
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Would you like to continue? Please press 'Y' to continue or 'N' to exit");
                Console.WriteLine("If you would like to calculate Volume, please press 'V'");

                String userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "n")
                {
                    Console.WriteLine("Goodbye! Thanks for coming!");
                    break;
                }
                else if (userAnswer == "y")
                {
                    continue;
                }
                else if (userAnswer == "v")
                {
                    Console.Write("Please enter the height of the room: ");
                    double height = double.Parse(Console.ReadLine());
                    double volume = height * width * length;
                    Console.WriteLine("Volume: " + volume);
                    Console.WriteLine("Would you like to continue? Please press 'Y' to continue or 'N' to exit");
                    String userAnswer2 = Console.ReadLine().ToLower();
                    if (userAnswer2 == "n")
                    {
                        Console.WriteLine("Goodbye! Thanks for coming!");
                        break;
                    }
                    else if (userAnswer2 == "y")
                    {
                        continue;
                    }
                }
            }
        }
    }
}



        

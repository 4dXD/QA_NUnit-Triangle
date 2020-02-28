using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLee8785Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOption = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("************M E N U*************");
                Console.WriteLine("1. Enter triangel dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("********************************");
                Console.Write("Choose a menu: ");

                inputOption = Console.ReadLine();

                if (inputOption == "1")
                {
                    bool flag = true;

                    do {
                        Console.Write("Please enter a number for the first side of a triangle:  ");
                        string triangleSide1 = Console.ReadLine();

                        Console.Write("Please enter a number for the second side of a triangle: ");
                        string triangleSide2 = Console.ReadLine();

                        Console.Write("Please enter a number for the last side of a triangle:   ");
                        string triangleSide3 = Console.ReadLine();

                        if(uint.TryParse(triangleSide1, out uint side1)&& uint.TryParse(triangleSide2, out uint side2)&& uint.TryParse(triangleSide3, out uint side3))
                        {
                            flag = false;
                            Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
                        }
                        else
                        {
                            Console.WriteLine("Wrong input value entered. Please enter Positive Integer(0 ~ "+ uint.MaxValue +")");
                        }

                    } while (flag);
                }

            } while (inputOption != "2");

        }
    }
}

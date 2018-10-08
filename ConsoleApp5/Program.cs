 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true; //cont is only used for if the process wants to be repeated.

            while (cont)
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Please enter the Length");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Width");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height");
                double height = double.Parse(Console.ReadLine());

                //Hopefully data input is in numbers. Here is the mathmatical formulas for them.
                double Area = length * width;
                double Perimeter = length * 2 + width * 2;
                double Volume = Area * height;

                Console.WriteLine("The area is {0}", Area);
                Console.WriteLine("The Perimeter is {0}", Perimeter);
                Console.WriteLine("The Volume is {0}", Volume);
                Console.ReadKey();

                Console.WriteLine("Would you like to run the program again? (Y/N):");

                if (Console.ReadLine() == "n")
                {
                    cont = false;
                }


            }
        }
    }
}

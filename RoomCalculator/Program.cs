using System;

namespace RoomCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");    //intro
            bool isCalculating = true; //exit condition
            do {
                // prompt the user for input
                Console.Write("Enter Length:");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width:");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter Height:");
                double height = double.Parse(Console.ReadLine());

                // calculate values and output results
                Console.WriteLine("Area:" + length * width);
                Console.WriteLine("Perimeter:" + (2 * length + 2 * width));
                Console.WriteLine("Volume:" + length * width * height);

                // ask user to go again
                Console.WriteLine("\nContinue(y/n)");
                string answer = Console.ReadLine();
                if(!(string.Equals(answer,"y")))
                    isCalculating = false; 
            } while (isCalculating);
        }
    }
}

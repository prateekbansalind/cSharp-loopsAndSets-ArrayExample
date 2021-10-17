using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of 3 names.
            //Ask the user which number to select.When the user gives you a number, return that name.

            string[] firstNames = new string[] { "Harry", "Justin", "Prince" };

            Console.Write("Please type a number in between 0 and 2 to get a name of a person: ");
            string xText = Console.ReadLine();

            int x = int.Parse(xText);

                


            Console.WriteLine($"You have typed number {x} : {firstNames[x]}");



            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public class OutputHandler
    {
        public void PrintMenu()
        {
            var menuOptions = new List<string> {"Exit", "Login"};

            //Menu options:

            Console.WriteLine(@"____________________
Please choose one of the following options (number):");
            for (var i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine(i +". " +menuOptions[i]);
            }
            Console.WriteLine(@"____________________");
        }

        public void InputNotValidException(string message)
        {
            Console.WriteLine("Invalid input: " + message);
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
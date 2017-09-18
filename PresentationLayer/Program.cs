using System;

namespace PresentationLayer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var inputHandler = new InputHandler();
            var outputHandler = new OutputHandler();
            var nextLoop = true;
            while (nextLoop)
            {
                outputHandler.PrintMenu();
                nextLoop = inputHandler.ChosenOption(Console.ReadLine());
            }
        }
    }
}
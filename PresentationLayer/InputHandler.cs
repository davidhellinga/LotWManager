using System;
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public class InputHandler
    {
        public bool ChosenOption(string chosenOption)
        {
            int switchOption=-1;
            if (TestInput(chosenOption))
            {
                switchOption = int.Parse(chosenOption);
            }
            switch (switchOption)
            {
                case 0: return false;
                case 1: var loginHandler=new LoginHandler();
                    loginHandler.StartLoginProcess();
                    return true;
            }
            return true;
        }

        public bool TestInput(string input)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if(regexItem.IsMatch(input))
            {
                return true;
            }
            var outputHandler=new OutputHandler();
            outputHandler.InputNotValidException("No special characters allowed");
            return false;
        }

        public string ReadInput()
        {
            var input = Console.ReadLine();
            return TestInput(input) ? input : null;
        }
    }
}
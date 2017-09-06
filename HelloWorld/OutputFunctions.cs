using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OutputFunctions : Greeting
    {
        public void SayHelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
            LeaveAMessage();
        }

        private bool LeaveAMessage()
        {
            bool wouldLikeToContinue = false;
            string userInput = "";
            while (wouldLikeToContinue == false)
            {
                Console.WriteLine("Would you like to add a message for someone else? Y/N");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "y" || userInput == "yes")
                {
                    wouldLikeToContinue = true;
                    EnterMessage();
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("Very well, this program will close in five seconds. Thank you and have a good day!");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please try again!");
                }
            }

            return wouldLikeToContinue;
        }

        private void EnterMessage()
        {
            Console.WriteLine("This works.");
            Console.ReadKey();
        }
    }
}

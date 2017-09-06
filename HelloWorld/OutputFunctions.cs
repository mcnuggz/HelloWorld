using System;
using System.IO;
using System.Threading;

namespace HelloWorld
{
    public class OutputFunctions : Greeting
    {
        public void SayHelloWorld()
        {
            Console.WriteLine("Hello World");
            Thread.Sleep(2000);
            LeaveAMessage();
        }

        public bool LeaveAMessage()
        {
            bool wouldLikeToContinue = false;
            string userInput = "";

            while (wouldLikeToContinue == false)
            {
                Console.WriteLine("Would you like to add a message? Y/N");
                //takes input and lowercases it for consistency
                userInput = Console.ReadLine().ToLower();
                if (userInput == "y" || userInput == "yes" || userInput == "yep")
                {
                    wouldLikeToContinue = true;
                    EnterMessage();
                }
                else if (userInput == "n" || userInput == "no" || userInput == "nope")
                {
                    Console.WriteLine("Read all Messages or Close?");
                    string userInput2 = Console.ReadLine().ToLower();
                    if (userInput2 == "read all messages" || userInput2 == "read")
                    {
                        DataStorage.DisplayMessages();
                    }
                    else
                    {
                        CloseApp();
                    }                   
                }
                else
                {
                    Console.WriteLine("Please try again!" + Environment.NewLine);
                }
            }
            return wouldLikeToContinue;
        }

        private void EnterMessage()
        {
            Console.WriteLine("Please leave your message now!");
            string userMessage = "";
            userMessage = Console.ReadLine();
            string userName = "";
            Console.WriteLine("Enter your name!");
            userName = Console.ReadLine();
            DataStorage.SaveMessage(userMessage, userName);
        }

        public void CloseApp()
        {
            Console.WriteLine("This program will close in five seconds. You can find the text file with your messages on your desktop. Thank you and have a good day!");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}

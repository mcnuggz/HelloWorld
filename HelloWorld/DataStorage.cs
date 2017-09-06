using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class DataStorage
    {
        
        public static void SaveMessage(string message, string name)
        {
            OutputFunctions outputFunctions = new OutputFunctions();
            Console.WriteLine(Environment.NewLine);
            string confirmationMessage = "Message Saved!";
            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + @"\Messages.txt", true))
            {
                writer.WriteLine(DateTime.Now + ": " + message + " (" + name + ")");                
            }
            Console.WriteLine(confirmationMessage + Environment.NewLine);
            outputFunctions.LeaveAMessage();


        }

        public static void DisplayMessages()
        {
            string line = "";
            using (StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Messages.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}

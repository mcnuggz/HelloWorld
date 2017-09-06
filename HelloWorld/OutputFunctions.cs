using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OutputFunctions : Greeting
    {
        public void SayHelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}

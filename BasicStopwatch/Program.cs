using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); //Instantiate stopwatch object

            var message = "Type start to begin watch";

            //While loop allows user to continually toggle between start and stopping the watch until they type exit.
            while (true)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();
                switch (input)
                {
                    case "start":
                        stopwatch.StartWatch();
                        message = "Type stop to end watch";
                        break;
                    case "stop":
                        stopwatch.EndWatch();
                        Console.WriteLine(stopwatch.DisplayTime());
                        message = "Type start to begin watch, or exit to quit application.";
                        break;
                }

                if(input == "exit")
                {
                    break;
                }
                
            } 
        }
    }
}

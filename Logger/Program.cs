using System;
using System.IO;

namespace Logger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("To run the logger please enter 'Run' ");
            string startLogger = Console.ReadLine();
            if (startLogger == "Run")
            {
                Starter starter = new Starter();
                starter.Run();
            }

            string log = @"c:\log\log.txt";
            if (!File.Exists(log))
            {
                File.WriteAllText(log, Logger.Instance.GetAllLogs());
            }
        }
    }
}

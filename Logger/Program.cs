using System;

namespace Logger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ");
            string startLogger = Console.ReadLine();
            if (startLogger == "Run")
            {
                Starter starter = new Starter();
                starter.Run();
            }
        }
    }
}

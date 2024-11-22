using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run(); //class return type is run
        }

        internal void run()
        {

            Console.WriteLine("Dit is nu de start van mijn programma");
        }
      
    }
}

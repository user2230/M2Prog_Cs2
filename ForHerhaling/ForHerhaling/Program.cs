
using System;

namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.run();
        }

        private void run()
        {
            double[] prijzen = new double[] { 0, 99, 5.60, 10.11, 5.20 };
            string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "kaas broodje", "lasagne" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker",
                Sterren = 5
            };
            formulieren[1] = new Formulier()
            {
                Feedback = "heel koud maar lekker",
                Sterren = 3
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artiekelen[i]);
                
            }   
            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
            }
        }
    }
        internal class Formulier
        {

            internal int Sterren { get; set; }

            internal string Feedback { get; set; }  
        }
        
    
}

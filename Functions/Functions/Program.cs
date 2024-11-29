using System;

namespace Functions
{
    internal class Program
    {
        string[] vragen =
        {
                "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?",
                "In May 2022, the government of what European nation banned its employees from using American gaming terms such as \"e-sports,\" instead using their domestic language counterparts like \"jeu video de competition?"
            };
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run(); //class return type is run
        }

        internal void run()
        {

            Console.WriteLine("Dit is nu de start van mijn programma");
            string antwoord1 = GetRandomVraag();
            string antwoord2 = Vraag1();
            Console.WriteLine(antwoord1);
            string vraag0 = GetVraag(0);

        }
        internal string Vraag1()

        {
            Console.WriteLine("how long did you think i would survive");
            string antwoord = Console.ReadLine();

            return antwoord;
        }
        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
        internal string GetRandomVraag()
        {

            Random rand = new Random();
            int dobbel = rand.Next(0, vragen.Length);
             
            return GetVraag(dobbel);
        }




    }


}



   
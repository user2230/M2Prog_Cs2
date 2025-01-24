using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            string[] characters = new string[]
            {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };

            List<string> characterList = new List<string>();

            characterList.Add("Lara Croft");

            foreach (string character in characters)
            {
                characterList.Add(character);
            }

            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }
        }
    }
}
   
        

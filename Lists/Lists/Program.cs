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
            List<double> reviews = new List<double>() { 0.9, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1, 11.1, 12.5, 342.97 };
            List<Pickup> pickups = new List<Pickup>();
            List<Mob> mobs = new List<Mob>();

            characterList.Add("Lara Croft");


            reviews.Remove(342.97);
            reviews.RemoveAt(0);


            foreach (string character in characters)
            {
                characterList.Add(character);
                Console.WriteLine(character);
            }


            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }

            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }


            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };
                pickups.Add(pickup);
            }


            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                if (pickups[i] == null)
                {
                    Console.WriteLine("pickup " + i + " Niet");
                    pickups.RemoveAt(i);
                }
                Console.WriteLine("pickup " + i + " wel");
            }

            Mob marley = new Mob()
            {
                hp = 100,
            };
            Mob bob = new Mob()
            {
                hp = 50,
            };
            mobs.Add(marley);
            mobs.Add(bob);

            mobs[0].TakeDamage(10);
            mobs[1].TakeDamage(200);
        }
    }
}


class Pickup
{
    internal int x, y;
}

class Mob
{
    internal bool isDead;
    internal int hp = 10;

    internal void TakeDamage(int damage)
    {
        if (hp > 0)
        {
            hp -= damage;
        }
        else
        {
            ;
            hp = 0;
            isDead = true;
        }

        Console.WriteLine("hp is: " + hp);
        Console.WriteLine("isDead: " + isDead);
    }
}
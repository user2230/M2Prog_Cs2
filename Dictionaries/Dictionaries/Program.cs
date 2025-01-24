namespace Dictionaries
{
    internal class Program
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        static void Main()
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            personeelOpNummer.Add(469024, "pim");
            personeelOpNummer.Add(749145, "pam");

            string pim = personeelOpNummer[469024];
            string pam = personeelOpNummer[749145];

            Console.WriteLine(pim + "\n" + pam);

            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}
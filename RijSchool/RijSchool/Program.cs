namespace RijSchool
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
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                KilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                KilometerStand = 65739,
                merk = "volvo"
            };
            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            Student student = new Student()
            {
                LesPakket = new LesPakket()
                {
                    urenGekocht = 30,
                    urenVerbruikt = 15,
                    examenPogingen = 2,
                    automaat = true
                },

                TheorieTest = new TheorieTest()
                {
                    aantalFouten = 3,
                    gehaald = true,
                    afnameDatum = new DateTime(2024, 2, 3),
                },
                RijTest = new RijTest()
                {
                    gehaald = false,
                    afnameDatum = new DateTime(2024, 2, 3),
                }
             };


            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                RijLeraar = rijLeraar,
                student = student,
                tijd = 1130,
            };
     

        }
            
    }
}

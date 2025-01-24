namespace Constructors
{
    internal class Program
    {
  
       
            
        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
            Quiz quiz = new Quiz(10);
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");

            for (int i = 0; i < quiz.vragen.Length; i++)
            {
                quiz.StelVraag(i);
            }
        }
        static void Main(string[] args)
        {
                Program program = new Program();
                program.Run();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
        }
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, quizVraag);
        }

        internal void StelVraag(int index);
        {
            Quizvraag vraag = QuizVraag[index];
            QuizVraagAntwoord
            

    }
}

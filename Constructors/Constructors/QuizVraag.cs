﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class QuizVraag
    {

        internal string vraag;
        internal string antwoord;

        internal QuizVraag(string vraag, string antwoord)

        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
     

    }
}

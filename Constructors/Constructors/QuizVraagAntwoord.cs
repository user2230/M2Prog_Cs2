﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal bool goed;
        internal QuizVraagAntwoord(QuizVraag vraag)
        {
            vraag = vraag;
            goed = false;
        }
    }
  
    
}

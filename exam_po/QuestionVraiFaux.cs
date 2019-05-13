using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal sealed class QuestionVraiFaux : Question
    {
        public QuestionVraiFaux(int id, int ponderation, string enonce, int reponse) : base(id, ponderation, enonce, reponse)
        {
            
        }
    }
}

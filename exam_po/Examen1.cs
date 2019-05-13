using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class Examen1 : Examen
    {
        public Examen1(Question[] questions) : base("EXAMEN #1")
        {
            foreach(Question question in questions)
            {
                AjouterQuestion(question);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    class Reponse
    {
        Question question;
        int choix;

        public Reponse(Question question, int choix)
        {
            this.question = question;
            this.choix = choix;
        }

        public int GetResultat()
        {
            return question.VerifierChoix(choix);
        }

        public int GetQuestionPonderation()
        {
            return question.Ponderation;
        }
        public int GetQuestionId()
        {
            return question.Id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class Examen
    {
        private List<Question> questions;
        private EnteteExamen enteteExamen;
        public EnteteExamen Entete
        {
            get
            {
                return enteteExamen;
            }
        }
        
        public Examen(string titre)
        {
            questions = new List<Question>();
            enteteExamen = new EnteteExamen(titre, questions);
        }

        public int GetNbQuestions()
        {
            return questions.Count;
        }

        public Question GetQuestion(int noQuestion)
        {
            foreach(Question question in questions)
                if (question.Id == noQuestion)
                    return question;

            throw new JPAException("La question n'existe pas");
        }

        protected void AjouterQuestion(Question question)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                if (question == questions[i])
                {
                    throw new JPAException("La question existe déjà");
                }
            }

            questions.Add(question);
                 
        }
    }
}

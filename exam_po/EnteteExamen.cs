using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class EnteteExamen
    {
        private string titre;

        private List<Question> questions;
        public string Titre
        {
            get
            {
                return titre;
            }
        }

        public EnteteExamen(string titre, List<Question> questions)
        {
            this.titre = titre;
            this.questions = questions;
        }
        public override string ToString()
        {
            int pond = 0;

            foreach (Question question in questions)
            {
                pond += question.Ponderation;
            }

            return "TITRE > " + titre + "\n" + "- Nombre de questions > " + questions.Count + "\n" + "- Ponderation > " + pond + "\n-----------------------------------------";
        }
    }
}

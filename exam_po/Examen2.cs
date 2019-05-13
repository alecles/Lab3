using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal sealed class Examen2 : Examen
    {

        public Examen2(string titre) : base(titre)
        {
            AjouterQuestion(new QuestionVraiFaux(1, 1, "La POO est paradigme? Faux = 0, Vrai = 1", 1));
            AjouterQuestion(new QuestionVraiFaux(2, 1, "Un paradigme est un langage de programmation? Faux = 0, Vrai = 1", 0));
            AjouterQuestion(new QuestionVraiFaux(3, 2, "La POO est un langage de programmation? Faux = 0, Vrai = 1", 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class ChargeurExamen
    {
        static public Examen GetExamen(int examenId)
        {
            if (examenId == 1)
            {
                return GetExamen1();
            }

            else if (examenId == 2)
            {
                return new Examen2("EXAMEN #2");               
            }

            else
            {
                throw new JPAException("Impossible de charger l'examen " + examenId);
            }

            
        }

        static private Examen GetExamen1()
        {
            string[] choix = { "Departement d'informatique du Cegep de Jonquiere", "DIssidence Conjointe du Jeu", "Autre"};
            string[] choix2 = { "PixelisationElement", "Picture Element", "Autre chose", "Aucune de ces réponses" };   
            Question[] questions = { new Question(1, 2, "Que veut dire DICJ?", choix, 0), new Question(2, 1, "Que veut dire PIXEL?", choix2, 1) }; 

            return new Examen1(questions);
        }

    }

    
}

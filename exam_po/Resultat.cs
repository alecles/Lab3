using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class Resultat
    {
        private DateTime moment;
        private EnteteExamen enteteExamen;
        private List<Reponse> reponses;

        public Resultat(EnteteExamen enteteExamen, List<Reponse> reponses)
        {        
            this.enteteExamen = enteteExamen;
            this.reponses = reponses;
            moment = DateTime.Now.ToLocalTime();
        }
        public string GetBilan()
        {
            int resultat = 0,total = 0;

            string retour = "-----------------------------------------\n";

            foreach (Reponse reponse in reponses)

            {

                retour += "Question : " + reponse.GetQuestionId() + " > " + reponse.GetResultat() + "/" + reponse.GetQuestionPonderation() + "\n";

                total += reponse.GetQuestionPonderation();

                resultat += reponse.GetResultat();

            }

            retour += "-----------------------------------------\n";

            retour += "RESULTAT > " + resultat + "/" + total + " = " + ((resultat * 100) / total) + "%";

            return enteteExamen + "\n" + retour + "\n"; ;  
        }
    }
}

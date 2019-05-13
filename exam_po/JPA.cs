using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    public partial class JPA
    {
        private Profil profil; //**

        public JPA()
        {
            
        }

        public void Authentification()
        {
            profil = new Profil(LectureIdentite());
        }

        public void FaireExamen()
        {
            if (profil == null)
            {
                throw new JPAException("Impossible de faire un examen sans authentification\n");
            }

            Examen examen = ChargeurExamen.GetExamen(LectureIdExamen());
            Console.WriteLine(" ");
            List<Reponse> reponses = new List<Reponse>();

            AfficherEnteteExamen(examen.Entete);

            for (int i = 0; i < examen.GetNbQuestions(); i++)
            {
                Question question = examen.GetQuestion(i + 1);
                AfficherQuestion(question);
                int choix = LectureChoix();
                Console.WriteLine(" ");

                Reponse reponse = new Reponse(question,choix);
                reponses.Add(reponse);
            }

            Resultat resultat = new Resultat(examen.Entete,reponses);
            profil.AjouterResultat(resultat);
        }

        public void AfficherResultats()
        {
            if (profil == null)
            {
                throw new JPAException("Impossible d'afficher un profil sans authentification\n");
            }
            AfficherProfil();
        }      

    }
}

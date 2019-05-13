using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    public partial class JPA
    {
        private string LectureIdentite()
        {
            Console.WriteLine("CHARGEMENT DU PROFIL");
            Console.Write("Inscrire votre nom d'utilisateur >");
            string utilisateur = Console.ReadLine();
            Console.WriteLine(" ");
            return utilisateur;
        }

        private int LectureIdExamen()
        {
            Console.WriteLine("CHOIX DE L'EXAMEN");
            Console.Write("Inscrire votre no d'examen >");

            try
            {
                int noExamen = Convert.ToInt32(Console.ReadLine());
                return noExamen;
            }

            catch (Exception e)
            {
                throw new JPAException("Impossible de lire le numéro de l'examen", e);
            }
           
        }

        private void AfficherEnteteExamen(EnteteExamen enteteExamen)
        {
            Console.WriteLine(enteteExamen);
        }

        private void AfficherQuestion(Question question)
        {
            Console.WriteLine("Question " + question.Id + " (" + question.Ponderation + ")");
            Console.WriteLine(question.Enonce);
          


            for (int i=0;i < question.Choix.Length;i++)
            {
                Console.WriteLine("("+ i +")" +question.Choix[i]);
            }
        }

        private int LectureChoix()
        {
            Console.Write("Inscrire vote choix >");
            int choix = -1;

            do
            {
                try
                {                   
                    choix = Convert.ToInt32(Console.ReadLine());

                }

                catch (FormatException fe)
                {
                    Console.WriteLine("Reponse invalide : " + choix);
                }
            }
            while (choix == -1);

            return choix;
        }

        private void AfficherProfil()
        {
            Console.WriteLine("AFFICHAGE DU PROFIL");
            Console.WriteLine("Nom > "+profil.GetNom());
            Console.WriteLine("Moment : "+ DateTime.Now.ToLocalTime());
            Console.WriteLine(" ");

            foreach (Resultat resultat in profil.GetResultats())
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(resultat.GetBilan());
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}

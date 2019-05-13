using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class Profil
    {
        private string nom;
        private List<Resultat> resultats = new List<Resultat>();

        public Profil(string nom)
        {           
            if (nom == null || nom == "")           
               throw new JPAException("Identité incorrecte, impossible de créer le profil\n");

            
            
            this.nom = nom;
        }

        public string GetNom()
        {
            return nom;
        }

        public List<Resultat> GetResultats()
        {
            return resultats;
        }

        public void AjouterResultat(Resultat resultat)
        {
            resultats.Add(resultat);
            
        }

    }
}

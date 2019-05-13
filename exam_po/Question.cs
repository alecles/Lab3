using System;
using System.Collections.Generic;
using System.Text;

namespace exam_poo
{
    internal class Question
    {
        private int id;
        private int ponderation;
        private string enonce;
        private string[] choix;
        private int reponse;

        public int Reponse
        {
            get
            {
                return reponse;
            }
        }

        public int Ponderation
        {
            get
            {
                return ponderation;
            }
        }
        public string Enonce
        {
            get
            {
                return enonce;
            }
        }
        public string[] Choix
        {
            get
            {
                return choix;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }


        public Question(int id, int ponderation, string enonce, string[] choix, int reponse)
        {
            if(reponse < 0 || reponse >= choix.Length)
            {
                throw new JPAException("Ce choix n'existe pas");
            }

            this.id = id;
            this.ponderation = ponderation;
            this.enonce = enonce;
            this.choix = choix;
            this.reponse = reponse;
        }

        public Question(int id, string enonce, string[] choix, int reponse) : this(id,1,enonce,choix,reponse)
        {

        }

        public int VerifierChoix(int choix)
        {
            if (choix == reponse)
            {
                return ponderation;
            }

            else
            {
                return 0;
            }
        }

        protected Question(int id, int ponderation, string enonce, int reponse)
        {
            this.id = id;
            this.ponderation = ponderation;
            this.enonce = enonce;
            choix = new string[0];
            this.reponse = reponse;
        }
    }
}

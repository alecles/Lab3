using Lab3;
using System;
using System.IO;
using exam_poo;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo exceptionsFile = new FileInfo(@"errors.txt");
            TextWriter exceptionWriter = new StreamWriter(exceptionsFile.FullName);
            Console.SetError(exceptionWriter);

            JPA jpa = new JPA();
            int choix = -1;
            do
            {
                choix = GetChoixMenu();

                try
                {
                    switch (choix)
                    {
                        case 1:
                            jpa.Authentification();
                            break;
                        case 2:
                            jpa.FaireExamen();
                            break;
                        case 3:
                            jpa.AfficherResultats();
                            break;
                        case 4:
                            throw new JPAException("Mon exeption", new Exception("inner"));
                    }
                }

                catch(JPAException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.Error.WriteLine(exception);
                }

                
            }
            while (choix != 0);

            using (TextWriter errorWriter = Console.Error)
            {
                errorWriter.Close();
                Console.SetError(new StreamWriter(Console.OpenStandardError()));
            }
        }

        private static int GetChoixMenu()
        {
            int choix = -1;

            Console.WriteLine("MENU principal");
            Console.WriteLine("(1) Authentification");
            Console.WriteLine("(2) Faire un examen");
            Console.WriteLine("(3) Afficher les resultats");
            Console.WriteLine("(0) Quitter");

            do
            {
                try
                {
                    Console.Write(" > ");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Entree incorrecte!");
                }
            }
            while (choix == -1);
            Console.WriteLine();
            return choix;
        }
    }
}

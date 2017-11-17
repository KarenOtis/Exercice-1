using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est ton nom?");
            String nom = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quel est ton prénom?");
            String prenom = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quelle est ta date de naissance?");
            DateTime x = DateTime.Parse(Console.ReadLine());
            DateTime y = DateTime.Now;
            TimeSpan duree = y - x;
            Console.WriteLine();

            Console.WriteLine("Écrire un nombre entre 0 et 100.");
            int nb1 = int.Parse(Console.ReadLine());
            bool nb3 = nb1 > 50;
            Console.WriteLine();

            Console.WriteLine("Bonjour {0} {1}!", prenom, nom);
            Console.WriteLine();

            Console.WriteLine("Tu as {0} jours.", duree.Days);
            Console.WriteLine();

            Console.WriteLine("Ton {0} est supérieur à 50? {1}", nb1, nb3);

            Console.WriteLine("BOOOMMMM");


            


            



            



        }
    }
}

using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Création d'un repas bon marché avec le serveur (directeur)
            IMonteurRepas monteurRepasBonMarche = new MonteurRepasBonMarche();
            Serveur serveur = new Serveur(monteurRepasBonMarche);
            serveur.PreparerRepas();
            Repas repasBonMarche = serveur.ObtenirRepas();
            
            // Création d'un repas coûteux avec le serveur (directeur)
            IMonteurRepas monteurRepasCouteux = new MonteurRepasCouteux();
            serveur.ChangerMonteurRepas(monteurRepasCouteux);
            serveur.PreparerRepas();
            Repas repasCouteux = serveur.ObtenirRepas();

            // Afficher les deux repas qui ont été créés avec le serveur (directeur)
            Console.WriteLine("Repas Bon Marché");
            Console.WriteLine(repasBonMarche.ToString());
            Console.WriteLine("\nRepas Coûteux");
            Console.WriteLine(repasCouteux.ToString());
        }
    }
}
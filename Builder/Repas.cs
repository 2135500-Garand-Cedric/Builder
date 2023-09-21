using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Le produit final produit par le builder
    /// </summary>
    public class Repas
    {
        private string breuvage = "";
        private string entree = "";
        private string platPrincipal = "";
        private string dessert = "";
        /// <summary>
        /// Set le breuvage
        /// </summary>
        /// <param name="breuvage">le breuvage a mettre</param>
        public void SetBreuvage(string breuvage)
        {
            this.breuvage = breuvage;
        }
        /// <summary>
        /// set l'entree
        /// </summary>
        /// <param name="entree">l'entree a mettre</param>
        public void SetEntree(string entree)
        {
            this.entree = entree;
        }
        /// <summary>
        /// set le plat principal
        /// </summary>
        /// <param name="platPrincipal">le plat principal a mettre</param>
        public void SetPlatPrincipal(string platPrincipal)
        {
            this.platPrincipal = platPrincipal;
        }
        /// <summary>
        /// Set le dessert
        /// </summary>
        /// <param name="dessert">le dessert a mettre</param>
        public void SetDessert(string dessert)
        {
            this.dessert = dessert;
        }
        /// <summary>
        /// Retourne l'information du repas
        /// </summary>
        /// <returns>l'information du repas</returns>
        public override string ToString()
        {
            return "Voici les informations du repas:\nBreuvage: " + breuvage + 
                "\nEntrée: " + entree + 
                "\nPlat principal: " + platPrincipal + 
                "\nDessert: " + dessert;
        }
    }
}


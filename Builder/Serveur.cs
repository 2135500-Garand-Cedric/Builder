using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Le directeur du builder
    /// S'occuper de gerer la construction du produit final
    /// </summary>
    public class Serveur
    {
        /// <summary>
        /// Contient le monteurRepas a executer
        /// </summary>
        private IMonteurRepas monteurRepas;

        /// <summary>
        /// Constructeur de la classe Serveur
        /// </summary>
        /// <param name="monteurRepas">le monteurRepas</param>
        public Serveur(IMonteurRepas monteurRepas)
        {
            this.monteurRepas = monteurRepas;
        }
        /// <summary>
        /// Change le monteurRepas
        /// </summary>
        /// <param name="monteurRepas">le monteurRepas a mettre</param>
        public void ChangerMonteurRepas(IMonteurRepas monteurRepas)
        {
            this.monteurRepas = monteurRepas;
        }
        /// <summary>
        /// Construit le repas avec chaques parties individuelles
        /// </summary>
        public void PreparerRepas()
        {
            monteurRepas.ReinitialiserRepas();
            monteurRepas.Breuvage();
            monteurRepas.Entree();
            monteurRepas.PlatPrincipal();
            monteurRepas.Dessert();
        }
        /// <summary>
        /// Obtient le repas final produit par le monteurRepas
        /// </summary>
        /// <returns>Un repas</returns>
        public Repas ObtenirRepas()
        {
            return monteurRepas.ObtenirRepas();
        }

    }
}

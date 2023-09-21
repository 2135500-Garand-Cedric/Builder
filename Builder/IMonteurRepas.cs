using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Interface MonteurRepas
    /// </summary>
    public interface IMonteurRepas
    {
        /// <summary>
        /// Reinitialise le repas
        /// </summary>
        public void ReinitialiserRepas();
        /// <summary>
        /// Determine le breuvage
        /// </summary>
        public void Breuvage();
        /// <summary>
        /// Determine l'entree
        /// </summary>
        public void Entree();
        /// <summary>
        /// Determine le plat principal
        /// </summary>
        public void PlatPrincipal();
        /// <summary>
        /// Determine le dessert
        /// </summary>
        public void Dessert();
        /// <summary>
        /// Permet l'obtention du repas
        /// </summary>
        /// <returns>le repas</returns>
        public Repas ObtenirRepas();
    }
}

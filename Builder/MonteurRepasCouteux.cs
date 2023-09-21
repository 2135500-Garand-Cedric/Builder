using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Monte un repas couteux
    /// </summary>
    public class MonteurRepasCouteux : IMonteurRepas
    {
        private Repas repas = new();
        public void Breuvage()
        {
            repas.SetBreuvage("Vin Rouge");
        }
        public void Entree()
        {
            repas.SetEntree("Crevettes pannées");
        }
        public void PlatPrincipal()
        {
            repas.SetPlatPrincipal("Steak Wagyu");
        }
        public void Dessert()
        {
            repas.SetDessert("Gateau au fromage");
        }
        public Repas ObtenirRepas()
        {
            return repas;
        }
        public void ReinitialiserRepas()
        {
            repas = new Repas();
        }
    }
}

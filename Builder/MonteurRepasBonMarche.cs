using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Monte un repas bon marche
    /// </summary>
    public class MonteurRepasBonMarche : IMonteurRepas
    {
        private Repas repas = new();
        public void Breuvage()
        {
            repas.SetBreuvage("Eau");
        }
        public void Entree()
        {
            repas.SetEntree("Soupe");
        }
        public void PlatPrincipal()
        {
            repas.SetPlatPrincipal("Burger");
        }
        public void Dessert()
        {
            repas.SetDessert("Gateau aux carottes");
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

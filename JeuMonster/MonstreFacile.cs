using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonster
{
    public class MonstreFacile : Personnage
    {
        private const int degats = 10;

        public override bool EstVivant { get; set; }

        public MonstreFacile()
        {
            EstVivant = true;
        }

        public override void Attaque(Personnage joueur)
        {
            int lanceMonstre = LanceLeDe();
            int lanceJoueur = LanceLeDe();
            if (lanceMonstre > lanceJoueur)
                joueur.SubitDegats(degats);
        }

        public override void SubitDegats(int degat)
        {
            EstVivant = false;
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }

    }
}

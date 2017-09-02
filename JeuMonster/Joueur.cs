using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonster
{
    public class Joueur : PersonnageAPointsDeVie
    {

        public Joueur(int points) : base(points)
        {

        }

        public override void SubitDegats(int degats)
        {
            if (!BouclierFonctionne())
                PtsDeVies -= degats;
        }

        private bool BouclierFonctionne()
        {
            return De.LanceLeDe() <= 2;
        }
    }
}

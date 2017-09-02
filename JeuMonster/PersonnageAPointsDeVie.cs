using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonster
{
    public class PersonnageAPointsDeVie : Personnage
    {
        public int PtsDeVies { get; set; }
        public override bool EstVivant
        {
            get { return PtsDeVies > 0; }
            set { EstVivant = value; }
        }

        public PersonnageAPointsDeVie(int points)
        {
            PtsDeVies = points;
        }

        public override void Attaque(Personnage perso)
        {
            if (perso.GetType() == typeof(MonstreFacile))
            {
                int lanceJoueur = LanceLeDe();
                int lanceMonstre = LanceLeDe();
                if (lanceJoueur >= lanceMonstre)
                    perso.SubitDegats(0);
            }
            else
            {
                int nbPoints = LanceLeDe(26);
                perso.SubitDegats(nbPoints);
            }
        }

        public override void SubitDegats(int degats)
        {
            if (this.GetType() == typeof(Joueur))
                if (!BouclierFonctionne())
                    PtsDeVies -= degats;
                else
                    PtsDeVies -= degats;
        }

        private bool BouclierFonctionne()
        {
            return De.LanceLeDe() <= 2;
        }

        public static int LanceLeDe(int valeur)
        {
            return random.Next(1, valeur);
        }

    }
}

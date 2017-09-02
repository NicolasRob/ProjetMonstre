using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonster
{
    public abstract class Personnage
    {
        public abstract bool EstVivant { get; set; }
        protected static Random random = new Random();

        public abstract void Attaque(Personnage perso);
        public abstract void SubitDegats(int degat);
        public static int LanceLeDe()
        {
            return random.Next(1, 7);
        }

    }
}

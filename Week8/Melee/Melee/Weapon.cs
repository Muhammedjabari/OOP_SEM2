using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melee
{
    class Weapon
    {
        public int BaseDam { get; set; }
        public int BaseRange { get; set; }
        public int CritDam { get; set; }
        public int PokeDam { get; set; }
        public int AttackDam { get; set; }

        

        public Weapon(int baseDam, int baseRange, int critDam, int pokeDam, int attackDam)
        {
            BaseDam = baseDam;
            BaseRange = baseRange;    
            CritDam = critDam;
            PokeDam = pokeDam;
            AttackDam = attackDam;
        }

        public virtual int Crit()
        {
            int BaseDam = CritDam * 2;
            return BaseDam;
        }

        public double GetRandomeNumber(int percent)
        {
            Random random = new Random();
            return random.NextDouble();
        }

    }

}

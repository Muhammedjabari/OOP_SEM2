using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melee
{
    class Melee
    {
        public int MeleeCrit { get; set; }
        public int ActionPoint { get; set; }

        public Melee(int meleeCrit, int actionPoint)
        {
            MeleeCrit = meleeCrit;
            ActionPoint = actionPoint;
        }


    }
}

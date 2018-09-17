using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melee
{
    class Range
    {
        public int RangeCrit { get; set; }

        public int ActionPoint { get; set; }

        public Range(int rangeCrit, int actionPoint)
        {
            RangeCrit = rangeCrit;
            ActionPoint = actionPoint;
        }

        
    }
}

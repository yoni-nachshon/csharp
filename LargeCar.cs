using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class LargeCar:Car
    {
        public int maxPass = 50;
        public int stend;
        public int waightMax;

        public LargeCar(int color, string id, string model, int stend, int waightMax) : base(color, id, model)
        {
            this.stend = stend;
            this.waightMax = waightMax;

        }

        public override bool CanDrive(Driver d)
        {
            if(d.sizeCar < 3 || d.waightMax < waightMax) { return false; }
            return true;
        }
    }
}

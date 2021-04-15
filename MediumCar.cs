using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MediumCar:Car
    {
        int maxPass = 20;
        bool matchToKids;

        public MediumCar(int color, string id, string model, bool matchToKids):base(color,id,model)
        {
            this.matchToKids = matchToKids;
        }
        public override bool CanDrive(Driver d)
        {
            if (d.sizeCar > 2) { return false; }
            return true;

        }
    }
}

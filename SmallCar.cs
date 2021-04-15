using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SmallCar:Car
    {
        int maxPass = 4;

        public SmallCar(int color, string id, string model):base(color,id,model)
        {
            
        }

        public override bool CanDrive(Driver d)
        {
            return true;
        }
    }
}

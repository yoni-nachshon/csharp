using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Track:IDrive
    {
        int waightMax;

        public Track(int waightMax)
        {
            this.waightMax = waightMax;
                
        }

        public bool CanDrive(Driver d)
        {
            return false;
        }
    }
}

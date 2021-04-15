using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Car:IDrive
    {
        public int color;
        public string id;
        public string model;

        public Car(int color, string id, string model)
        {
            this.color = color;
            this.id = id;
            this.model = model;
        }

        public virtual bool CanDrive(Driver d)
        {
            return true;
        }

        public override string ToString()
        {
            return $"Color:{color} ID:{id} Model:{model}";
        }
    }
}

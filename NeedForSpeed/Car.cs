using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Car
    {
        public abstract int Speed { get; set; }
        public abstract string? Color { get; set; }
        public abstract string? Name { get; set; }
        public abstract string? Type {get; set; }
        public abstract int Record { get; set; }
        public abstract void CarInfo();
        public abstract void EngineCar();
        public abstract int SpeedСhange();
        public abstract void Finish();
     
    }
}

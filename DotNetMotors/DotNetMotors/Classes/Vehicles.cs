using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Vehicles
    {
        public abstract string Type { get; set; }
        public abstract string Engine { get; set; }
        public abstract string Color { get; set; }
        public abstract decimal PriceRange { get; set; }
        public virtual bool Fuel { get; set; } = false;

        public abstract void Move();
        public abstract void GetFuel();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public abstract class Birds : Warm_Blooded
    { 
        public abstract bool FlyAbility  { get; set; }


        public virtual int FlightAltitudeInMeters()

        {
            return 50;
        }


    }
}

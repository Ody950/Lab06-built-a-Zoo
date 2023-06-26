using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public abstract class Warm_Blooded : Animal
    {
        public abstract bool MaintainingBodyTemperature {get; set;}

        public abstract bool ThreatToHumans { get; set; }

        public virtual int SpeedAverageInKm()
        {
            return 50;
        }

        public virtual string Reproduction()
        {
            return "Animal reproduction by";
        }
    }
}

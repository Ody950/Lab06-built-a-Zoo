using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public abstract class Animal
    {

        public abstract int AverageLengthInMeters { get; set; }
        public abstract int AverageWeightInMetersInKg { get; set; }
        public virtual string Diet { get; set; }
        public abstract int Legs { get; set; }

       
        public virtual string Eat()
        {
            return "Animal eat";
        }

        public virtual string Sleep()
        {
            return "Animal sleep";
        }

        public virtual string Sound()
        {
            return "Animal sound";
        }
    }
}

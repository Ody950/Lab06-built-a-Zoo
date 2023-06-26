using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public abstract class Fish : Cold_Blooded
    {

        public abstract bool HaveGills { get; set; }


        public virtual string WaterSalinity()

        {
            return "The WaterSalinity for the water live in is";
        }


    }
}

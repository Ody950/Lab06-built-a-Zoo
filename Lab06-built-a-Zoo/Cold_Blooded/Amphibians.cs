using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab06_built_a_Zoo
{
    public abstract class Amphibians : Cold_Blooded
    {

        public abstract bool LivesNearTheWater { get; set; }


        public virtual string LifeCycle()

        {
            return "Her Life Cycle start by";
        }


    }
}

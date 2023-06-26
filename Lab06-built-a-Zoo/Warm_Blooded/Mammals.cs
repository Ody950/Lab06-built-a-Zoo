using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public abstract class Mammals : Warm_Blooded
    {

        public abstract bool Pouch { get; set; }
        public abstract bool ProducesMilk { get; set; }


        public virtual string CoversHerSkin()

        {
            return "Her skin covers by";
        }


    }
}

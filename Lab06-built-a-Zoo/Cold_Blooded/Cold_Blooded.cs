using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab06_built_a_Zoo
{
    public abstract class Cold_Blooded : Animal
    {
        public abstract bool HasPoison { get; set; }

        public abstract string Color { get; set; }

        
        public virtual string Home()
        {
            return "Live in";
        }
    }
}

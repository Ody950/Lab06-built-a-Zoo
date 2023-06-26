using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab06_built_a_Zoo
{
    public abstract class Reptiles : Cold_Blooded
    {

        public abstract bool LayingEggs { get; set; }
      

        public virtual string SkinTexture()

        {
            return "Her Skin Texture is";
        }


    }
}

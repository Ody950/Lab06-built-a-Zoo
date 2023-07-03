using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public class Frogs : Amphibians, CanSee
    {
        public override int AverageLengthInMeters { get; set; }
        public override int AverageWeightInMetersInKg { get; set; }
        public override string Diet { get; set; }
        public override int Legs { get; set; }
        public override bool HasPoison { get; set; }
        public override string Color { get; set; }
        public override bool LivesNearTheWater { get; set; }


        public Frogs()
        {
            AverageLengthInMeters = 2;
            AverageWeightInMetersInKg = 1;
            Diet = "Eat Weeds and insects";
            Legs = 4;
            HasPoison = true;
            Color = "frogs are different shades of 7 main colors including green, brown, grey, blue, yellow, red, and black.";
            LivesNearTheWater = true;
        }


        public override string Eat()
        {
            return "Adult frogs eat insects that they catch with their long, sticky tongue, and other invertebrates such as snails, slugs and worms.";
        }

        public override string Sleep()
        {
            return "Frogs may not sleep like humans but they do have periods of rest during which they tuck their limbs under their body, cover their eyes with their nictitating membrane and stay immobile for long periods of time.";
        }

        public override string Sound()
        {
            return " A croak";
        }


        public override string Home()
        {
            return "Frogs thrive in a large number of environments from tropical forests to frozen tundras to deserts. ";
        }

        public override string LifeCycle()

        {
            return "The life cycle of a frog from the time the eggs are laid until it is a young frog, the animal stays in water. Only when it is an adult frog will it leave the water. During its life the frog’s body shape changes from egg, to tadpole, to froglet, and then to an adult frog.";
        }



        public string CanSee()
        {
            return "Frogs have nearly a 360 degree view due to the positioning and design of their eyes. ";
        }






    }
}

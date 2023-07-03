using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab06_built_a_Zoo
{
    public class Crocodile : Reptiles, CanSee
    {

        public override int AverageLengthInMeters { get; set; }
        public override int AverageWeightInMetersInKg { get; set; }
        public override string Diet { get; set; }
        public override int Legs { get; set; }
        public override bool HasPoison { get; set; }
        public override string Color { get; set; }
        public override bool LayingEggs { get; set; }


        public Crocodile()
        {
            AverageLengthInMeters = 4;
            AverageWeightInMetersInKg = 300;
            Diet = "Carnivores";
            Legs = 4;
            HasPoison = false;
            Color = "Olive, Gray, Dark, grey to black, Green, Tan";
            LayingEggs = true;
        }


        public override string Eat()
        {
            return "Fish, Birds, Turtles, Frogs, Snakes, Wild, boar, Wildebeest, Sharks";
        }

        public override string Sleep()
        {
            return "Crocodiles can sleep with one eye open";
        }

        public override string Sound()
        {
            return "Grunt, growl, and hiss";
        }


        public override string Home()
        {
            return "Live throughout the tropics in Africa, Asia, the Americas and Australia. They are found mainly in freshwater sources like rivers, lakes, marshlands, as well as the brackish water near the mouth of the river.";
        }

        public override string SkinTexture()

        {
            return "Crocodile skin texture is rough and scaly.";
        }

        public string CanSee()
        {
            return "Crocodiles have excellent vision both in and out of water.";
        }
    }
}

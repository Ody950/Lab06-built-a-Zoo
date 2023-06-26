using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public class Tiger : Mammals
    {
        public override int AverageLengthInMeters { get; set; }
        public override int AverageWeightInMetersInKg { get; set; }
        public override string Diet { get; set; }
        public override int Legs { get; set; }
        public override bool MaintainingBodyTemperature { get; set; }
        public override bool ThreatToHumans { get; set; }
        public override bool Pouch { get; set; }
        public override bool ProducesMilk { get; set; }

        public Tiger()
        {
            AverageLengthInMeters = 3;
            AverageWeightInMetersInKg = 300;
            Diet = "Carnivores";
            Legs = 4;
            MaintainingBodyTemperature = true;
            ThreatToHumans = true;
            Pouch = false;
            ProducesMilk = true;
        }
        
        public override string Eat()
        {
            return "These apex predators primarily hunt large ungulates, such as wild boar and deer, but are also known to consume monkeys, buffalo, sloth bears, leopards and even crocodiles.";
        }

        public override string Sleep()
        {
            return "Tigers sleep a very long time, typically about 18 to 20 hours a day. ";
        }

        public override string Sound()
        {
            return "growl, roar";
        }


        public override int SpeedAverageInKm()
        {
            return 57;
        }

        public override string Reproduction()
        {
            return "tigers give birth to two to four cubs every two years";
        }

        public override string CoversHerSkin()

        {
            return "The tigers skin covers by hair";
        }
    }
}

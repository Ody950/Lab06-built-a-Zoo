using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public class Eagle : Birds, CanSee
    {
        public override int AverageLengthInMeters { get; set; }
        public override int AverageWeightInMetersInKg { get; set; }
        public override string Diet { get; set; }
        public override int Legs { get; set; }
        public override bool MaintainingBodyTemperature { get; set; }
        public override bool ThreatToHumans { get; set; }
        public override bool FlyAbility { get; set; }
       

        public Eagle()
        {
            AverageLengthInMeters = 1;
            AverageWeightInMetersInKg = 4;
            Diet = "Raptors";
            Legs = 2;
            MaintainingBodyTemperature = true;
            ThreatToHumans = true;
            FlyAbility = false;
        }

        public override string Eat()
        {
            return "Eagle Hunt other vertebrate animals. Their prey is typically large in comparison to their size.";
        }

        public override string Sleep()
        {
            return "The time the sun is down and as such they are up with the sunrise.";
        }

        public override string Sound()
        {
            return "chattering";
        }


        public override int SpeedAverageInKm()
        {
            return 60;
        }

        public override string Reproduction()
        {
            return "Eagles lay from 1 to 3 eggs";
        }

        public override int FlightAltitudeInMeters()

        {
            return 3963;
        }

        public string CanSee()
        {
            return "Eagles can see things from 20 feet away that we can only see from 5 feet away. ";
        }


    }
}

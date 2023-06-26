using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_built_a_Zoo
{
    public class Tuna : Fish
    {
        public override int AverageLengthInMeters { get; set; }
        public override int AverageWeightInMetersInKg { get; set; }
        public override string Diet { get; set; }
        public override int Legs { get; set; }
        public override bool HasPoison { get; set; }
        public override string Color { get; set; }
        public override bool HaveGills { get; set; }


        public Tuna() 
        {
            AverageLengthInMeters = 1;
            AverageWeightInMetersInKg = 200;
            Diet = "Eat fish meat";
            Legs = 0;
            HasPoison = false;
            Color = "Gray";
            HaveGills = true;
        }


        public override string Eat()
        {
            return "Juveniles eat fish, squid, and crustaceans, and adults feed mainly on baitfish such as herring, bluefish, and mackerel.";
        }

        public override string Sleep()
        {
            return "fishes don't sleep";
        }

        public override string Sound()
        {
            return "clicks";
        }


        public override string Home()
        {
            return "They are found mostly in temperate ocean waters but also in the tropics and cooler coastal regions.";
        }

        public override string WaterSalinity()

        {
            return "The range 33–42 ppt salinity";
        }
    }
}



using System;
using Xunit;
using Lab06_built_a_Zoo;
using System.Drawing;

namespace TestLab6
{
    public class UnitTest1
    {
       
            [Fact]
        /// <summary>
        /// Checks the Sleep(), Sound(), SpeedAverageInKm(), Reproduction(), FlightAltitudeInMeters()  Methods that the  Eagle inheritance from Animal, Warm_Blooded,Birds class.
        /// </summary>
        public void TestEagle()
            {

                //Arrange
                Eagle newEagle = new Eagle();

                //Act
                string sleep = newEagle.Sleep();
                string sound = newEagle.Sound();
                int speedAverage = newEagle.SpeedAverageInKm();
                string reproduction = newEagle.Reproduction();
                int flightAltitude = newEagle.FlightAltitudeInMeters();

            //Test
            Assert.Equal("chattering", sound);
            Assert.Equal("The time the sun is down and as such they are up with the sunrise.", sleep);
            Assert.Equal(60, speedAverage);
            Assert.Equal("Eagles lay from 1 to 3 eggs", reproduction);
            Assert.Equal(3963, flightAltitude);
        }





        [Fact]
        /// <summary>
        /// Checks the Sleep(), Sound(), SpeedAverageInKm(), Reproduction(), CoversHerSkin()  Methods that the  Tiger inheritance from Animal, Warm_Blooded,Mammals class.
        /// </summary>
        public void TestTiger()
        {

            //Arrange
            Tiger newTiger = new Tiger();

            //Act
            string sleep = newTiger.Sleep();
            string sound = newTiger.Sound();
            int speedAverage = newTiger.SpeedAverageInKm();
            string reproduction = newTiger.Reproduction();
            string coversHerSkin = newTiger.CoversHerSkin();

            //Test
            Assert.Equal("growl, roar", sound);
            Assert.Equal("Tigers sleep a very long time, typically about 18 to 20 hours a day. ", sleep);
            Assert.Equal(57, speedAverage);
            Assert.Equal("tigers give birth to two to four cubs every two years", reproduction);
            Assert.Equal("The tigers skin covers by hair", coversHerSkin);
        }



        [Fact]
        /// <summary>
        /// Checks the Sleep(), Sound(), Home(), SkinTexture()  Methods that the  Crocodile inheritance from Animal, Cold_Blooded,Reptiles class.
        /// </summary>
        public void TestCrocodile()
        {

            //Arrange
            Crocodile newCrocodile = new Crocodile();

            //Act
            string sleep = newCrocodile.Sleep();
            string sound = newCrocodile.Sound();
            string home = newCrocodile.Home();
            string skinTexture = newCrocodile.SkinTexture();
           

            //Test
            Assert.Equal("Grunt, growl, and hiss", sound);
            Assert.Equal("Crocodiles can sleep with one eye open", sleep);
            Assert.Equal("Live throughout the tropics in Africa, Asia, the Americas and Australia. They are found mainly in freshwater sources like rivers, lakes, marshlands, as well as the brackish water near the mouth of the river.", home);
            Assert.Equal("Crocodile skin texture is rough and scaly.", skinTexture);


        }



        [Fact]
        /// <summary>
        /// Checks the Sleep(), Sound(), Home(), LifeCycle()  Methods that the  Frogs inheritance from Animal, Cold_Blooded,Amphibians class.
        /// </summary>
        public void TestFrogs()
        {

            //Arrange
            Frogs newFrogs = new Frogs();

            //Act
            string sleep = newFrogs.Sleep();
            string sound = newFrogs.Sound();
            string home = newFrogs.Home();
            string lifeCycle = newFrogs.LifeCycle();


            //Test
            Assert.Equal(" A croak", sound);
            Assert.Equal("Frogs may not sleep like humans but they do have periods of rest during which they tuck their limbs under their body, cover their eyes with their nictitating membrane and stay immobile for long periods of time.", sleep);
            Assert.Equal("Frogs thrive in a large number of environments from tropical forests to frozen tundras to deserts. ", home);
            Assert.Equal("The life cycle of a frog from the time the eggs are laid until it is a young frog, the animal stays in water. Only when it is an adult frog will it leave the water. During its life the frog’s body shape changes from egg, to tadpole, to froglet, and then to an adult frog.", lifeCycle);


        }



        [Fact]
        /// <summary>
        /// Checks the Sleep(), Sound(), Home(), LifeCycle()  Methods that the  Tuna inheritance from Animal, Cold_Blooded,Fish class.
        /// </summary>
        public void TestTuna()
        {

            //Arrange
            Tuna newTuna = new Tuna();

            //Act
            string sleep = newTuna.Sleep();
            string sound = newTuna.Sound();
            string home = newTuna.Home();
            string lifeCycle = newTuna.WaterSalinity();


            //Test
            Assert.Equal("clicks", sound);
            Assert.Equal("fishes don't sleep", sleep);
            Assert.Equal("They are found mostly in temperate ocean waters but also in the tropics and cooler coastal regions.", home);
            Assert.Equal("The range 33–42 ppt salinity", lifeCycle);


        }




    }
}
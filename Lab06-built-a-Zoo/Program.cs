
using System;


namespace Lab06_built_a_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("......................The Warm Blooded......................");
            TheWarmBlooded();
            static void TheWarmBlooded()
            {
                Tiger TheTiger = new Tiger();
                Eagle TheEagle = new Eagle();
                Console.WriteLine();
                Console.Write($" The Tiger average length in meters is {TheTiger.AverageLengthInMeters} and it average weight in kg is {TheTiger.AverageWeightInMetersInKg} ");
                if(TheTiger.ProducesMilk)
                {
                    Console.Write("and the Tiger can produces milke.");
                }
                else 
                {
                    Console.Write("and the Tiger can't produces milke.");
                }

                Console.WriteLine();
                Console.Write($" The Eagle average length in meters is {TheEagle.AverageLengthInMeters} and it average weight in kg is {TheEagle.AverageWeightInMetersInKg} ");
                if (TheTiger.ProducesMilk)
                {
                    Console.Write("and the Eagle can produces milke.");
                }
                else
                {
                    Console.Write("and the Eagle can't produces milke.");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("......................The Cold Blooded......................");
            TheColdBlooded();
            static void TheColdBlooded()
            {
                Tuna TheTuna = new Tuna();
                Frogs TheFrogs = new Frogs();
                Crocodile TheCrocodile = new Crocodile();
                Console.WriteLine();
                Console.Write($" The Tuna average length in meters is {TheTuna.AverageLengthInMeters} and it average weight in kg is {TheTuna.AverageWeightInMetersInKg} ");
                if (TheTuna.HaveGills)
                {
                    Console.Write("and the Tuna Have Gills.");
                }
                else
                {
                    Console.Write("and the Tuna don't Have Gills.");
                }

                Console.WriteLine();
                Console.Write($" The Frogs average length in meters is {TheFrogs.AverageLengthInMeters} and it average weight in kg is {TheFrogs.AverageWeightInMetersInKg} ");
                if (TheFrogs.LivesNearTheWater)
                {
                    Console.Write("and the Frogs Lives Near The Water.");
                }
                else
                {
                    Console.Write("and the Frogs don't Lives Near The Water.");
                }
              

                Console.WriteLine();
                Console.Write($" The Crocodile average length in meters is {TheCrocodile.AverageLengthInMeters} and it average weight in kg is {TheCrocodile.AverageWeightInMetersInKg} ");
                if (TheCrocodile.LayingEggs)
                {
                    Console.Write("and the Crocodile can laying eggs.");
                }
                else
                {
                    Console.Write("and the Crocodile can't laying eggs.");
                }
                Console.WriteLine();
            }
        }
    }
}
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var penguin = new Bird()
            {
                Name = "Spiffy",
                Type = "Emperor Penguin",
                Age = 5,
                GenderPronouns = "He/him",
                HasOffspring = false,
                BirdSong = "squawk",
                WingSpan = 85,
                BeakColor = "black",
                CanFly = false
            };

            var turtle = new Reptile()
            {
                Name = "Shelly",
                Type = "Sea Turtle",
                Age = 15,
                GenderPronouns = "She/her",
                HasOffspring = false,
                TailLength = 8,
                LivesInWater = true,
                HasShell = true,
                NumberOfTeeth = 0,
            };
            penguin.Introduce();
            penguin.IntroduceBird();
            turtle.Introduce();
            turtle.IntroduceRept();
            


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
        }
    }
}
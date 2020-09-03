using System;

namespace FarmSystem.Test1
{
    public class Hen : IAnimal
    {
        /// <summary>
        /// Unique Id for the Hen
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// No of Legs available for the Hen
        /// </summary>
        public int NoOfLegs { get; set; } = 2;

        /// <summary>
        /// Function to make hen talk
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        /// <summary>
        /// Function to make hen run
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Hen is running");
        }

        /// <summary>
        /// Function to make hen walk
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Hen is walking");
        }
    }
}
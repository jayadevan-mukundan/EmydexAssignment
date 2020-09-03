using System;

namespace FarmSystem.Test1
{
    public class Horse : IAnimal
    {
        /// <summary>
        /// Unique Id for the Horse
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// No of Legs available for the Horse
        /// </summary>
        public int NoOfLegs { get; set; } = 4;

        /// <summary>
        /// Function to make horse talk
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        /// <summary>
        /// Function to make horse run
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

        /// <summary>
        /// Function to make horse walk
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Horse is walking");
        }
    }
}
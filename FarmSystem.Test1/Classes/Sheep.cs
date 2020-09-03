using System;

namespace FarmSystem.Test1
{
    public class Sheep : IAnimal
    {
        /// <summary>
        /// Unique Id for the Sheep
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// No of Legs available for the Sheep
        /// </summary>
        public int NoOfLegs { get; set; } = 4;

        /// <summary>
        /// Function to make sheep talk
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        /// <summary>
        /// Function to make sheep run
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }

        /// <summary>
        /// Function to make sheep walk
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Sheep is walking");
        }
    }

}
using System;

namespace FarmSystem.Test1
{
    public class Cow : IAnimal, IMilkableAnimal
    {
        /// <summary>
        /// Unique Id for the Cow
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// No of Legs available for the Cow
        /// </summary>
        public int NoOfLegs { get; set; } = 4;

        /// <summary>
        /// Function to make Cow talk
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        /// <summary>
        /// Function to make cow walk
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        /// <summary>
        /// Function to make cow produce milk
        /// </summary>
        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked");
        }

        /// <summary>
        /// Function to make cow run
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}
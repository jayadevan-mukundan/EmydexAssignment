using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem : IDisposable
    {
        public event EventHandler FarmEmpty;
        private Queue<IAnimal> animalsInsideFarm = new Queue<IAnimal>();

        //TEST 1
        public void Enter(IAnimal animal)
        {
            // hold the animals for future activities
            animalsInsideFarm.Enqueue(animal);
            // Animal entered inside the farm is displayed
            Console.WriteLine($"{animal.GetType().Name} has entered the farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            // Check if animals exists before scaring them
            if (animalsInsideFarm.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm");
                return;
            }

            //Test 2 : Modify this method to make the animals talk
            foreach (var animal in animalsInsideFarm)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            bool milkableAnimalFound = false;
            foreach (var animal in animalsInsideFarm)
            {
                // Check if any of the animals implements IMilkableAnimal interface
                if (animal is IMilkableAnimal)
                {
                    milkableAnimalFound = true;
                    // cast the object ti IMilkableAnimal to call the ProduceMilk function
                    ((IMilkableAnimal)animal).ProduceMilk();
                }
            }
            if (!milkableAnimalFound)
                Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            // Release each animal in order they entered
            while (animalsInsideFarm.Count > 0)
            {
                IAnimal animal = animalsInsideFarm.Dequeue();
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }
            // Call the event function when the farm is empty
            OnFarmEmpty(EventArgs.Empty);
        }

        // function to execute any event subscription
        protected void OnFarmEmpty(EventArgs e)
        {
            // notify the subscriber
            FarmEmpty?.Invoke(this, e);
        }

        public void Dispose()
        {
            // clear the reference to animals
            animalsInsideFarm = null;
        }
    }
}
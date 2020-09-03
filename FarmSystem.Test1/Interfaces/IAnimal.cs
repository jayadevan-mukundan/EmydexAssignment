namespace FarmSystem.Test1
{
    /// <summary>
    /// Interface for animals to implement
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Unique Id for the Animal
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// No of Legs available for th animal
        /// </summary>
        int NoOfLegs { get; set; }

        /// <summary>
        /// Function to make animal talk
        /// </summary>
        void Talk();

        /// <summary>
        /// function to make animal walk
        /// </summary>
        void Walk();

        /// <summary>
        /// function to make animal run
        /// </summary>
        void Run();
    }
}

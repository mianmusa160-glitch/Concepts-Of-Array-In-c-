using System;

namespace OneDArray
{
    class ForzaInventry
    {
        static void Main(string[] args)
        {
            // Assiging Value To String
            string[] CarInventory = new string[5];

            // Assign values to the array using index numbers.
            CarInventory[0] = "BMW M5";
            CarInventory[1] = "GTR R35";
            CarInventory[2] = "Bugatti Chiron";
            CarInventory[3] = "Ferrari LaFerrari";
            CarInventory[4] = "Koenigsegg Jesko";

            // header
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Welcome to My Car Inventory");
            Console.WriteLine("-----------------------------");

            // (Looping)
            for (int i = 0; i < CarInventory.Length; i++)
            {
                // Print index number and the Car name
                Console.WriteLine("Car Number " + i + " is: " + CarInventory[i]);
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
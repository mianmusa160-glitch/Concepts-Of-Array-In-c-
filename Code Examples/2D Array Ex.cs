using System;

namespace BackpackInventorySystem
{
    class RDR2Backpack
    {
        static void Main(string[] args)
        {
            // Imagine we have 4 items in a bag.Now devide the bag in  2 Rows and 2 Columns (4 slots total).
            string[,] backpack = new string[2, 2];

            // Top row items
            backpack[0, 0] = "rifles";   // Top-Left
            backpack[0, 1] = "medicine";   // Top-Right

            // Bottom row items
            backpack[1, 0] = "Food";  // Bottom-Left
            backpack[1, 1] = "alcohol";      // Bottom-Right

            Console.WriteLine("-----------------------------");
            Console.WriteLine("    Arthur's Inventory (Bag)");
            Console.WriteLine("-----------------------------");

            //loop

            for (int i = 0; i < 2; i++) // Loop for Rows
            {
                for (int j = 0; j < 2; j++) // Loop for Columns
                {
                    // item name.
                    string item = backpack[i, j];

                    //Display
                    Console.Write("| " + item + " |\t");
                }

              // line after every row
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
using System;

namespace RDR2Inventory
{
    class Saddlebags
    {
        static void Main(string[] args)
        {
            // Dimensions:2 Sides, 2 Pockets, 2 Slots
            // Side 0 = Left Bag, Side 1 = Right Bag
            string[,,] saddlebags = new string[2, 2, 2];

            // Left Bag (Food and Tonics)
            saddlebags[0, 0, 0] = "Canned Beans";
            saddlebags[0, 0, 1] = "Classic Oatcakes";
            saddlebags[0, 1, 0] = "Miracle Tonic";
            saddlebags[0, 1, 1] = "Health Cure";

            // Right Bag (Valuables and Ammo)
            saddlebags[1, 0, 0] = "Platinum watch";
            saddlebags[1, 0, 1] = "Gold Bar";
            saddlebags[1, 1, 0] = "Revolver Ammo";
            saddlebags[1, 1, 1] = "Rifle Ammo";

            Console.WriteLine("--------------------------------");
            Console.WriteLine("    Arthur's Horse Inventory");
            Console.WriteLine("--------------------------------");

            // Loops

            // Loop 1 Check each Side (Left/Right)
            for (int side = 0; side < 2; side++)
            {
                if (side == 0) Console.WriteLine("\n[ LEFT SADDLEBAG ]");
                else Console.WriteLine("\n[ RIGHT SADDLEBAG ]");

                // Loop 2 Check each Pocket (Top/Bottom)
                for (int pocket = 0; pocket < 2; pocket++)
                {
                    Console.Write("  Pocket " + pocket + ": ");

                    // Loop 3 Check specific items
                    for (int slot = 0; slot < 2; slot++)
                    {
                        string item = saddlebags[side, pocket, slot];
                        Console.Write(item + " | ");
                    }

                    Console.WriteLine(); // New line after each pocket
                }
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
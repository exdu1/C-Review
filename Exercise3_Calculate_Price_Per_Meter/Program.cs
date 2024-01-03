using System;

namespace Exercise3_Calculate_Price_Per_Meter {
    class Program {
        static void Main(string[] args) {
            /*Tile Limited wants a program allows its salesclerk to enter the length and width (in meters) of a rectangle and the price of a square meter of tile. The program should display the area of the rectangle and the total cost of the tile.
             */

            // INPUT
            int length;
            int width;
            int price;

            Console.Write("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width of the recangle: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of a square meter of tile: ");
            price = Convert.ToInt32(Console.ReadLine());

            // OUTPUT
            int costPerTile;

            // ALGORITHM
            costPerTile = (length * width) / price;

            Console.WriteLine($"The cost per tile is ${costPerTile}.");

        }
    }
}

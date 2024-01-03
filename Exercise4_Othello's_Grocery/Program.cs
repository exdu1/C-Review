using System;
using static System.Console;

namespace Exercise4_Othello_s_Grocery {
    class Program {
        static void Main(string[] args) {
            /*
             * Othello’s Grocery would like a program that will prompt the user for the weight and price of the produce, the price and capacity of plastic bag and then calculates and displays the total cost of the sale. You may assume that all customers will require bags. You may use the following sample inputs (price 11₵ per kg, weight 25kg and capacity of bag is 5 (one bag is able to hold 5 kg of produce), price of a plastic bag 5₵. The total cost is 300₵) 
             */

            // INPUT
            int weight;
            int pricePerKg;
            int pricePerBag;
            int capacityPerBag;

            Write("Enter the price per kg (\x00A2): ");
            pricePerKg = Convert.ToInt32(ReadLine());
            
            Write("Weight of product (kg): ");
            weight = Convert.ToInt32(ReadLine());

            Write("Enter the capactiy per bag (kg): ");
            capacityPerBag = Convert.ToInt32(ReadLine());

            Write("Enter Price of Bag (\x00A2): ");
            pricePerBag = Convert.ToInt32(ReadLine());

          
            // OUTPUT
            int totalBagCost;
            int productCost;
            int priceOfSale;

            // ALGORITHM
            totalBagCost = (weight / capacityPerBag) * pricePerBag;
            productCost = weight * pricePerKg;
            priceOfSale = productCost + totalBagCost;

            Console.WriteLine($"Your sale will be: {priceOfSale}\x00A2.");

         }
    }
}

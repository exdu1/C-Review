using System;

namespace Exercise1_Confectionary_Store {
    class Program {
        static void Main(string[] args) {

            /*A confectionary store wants a program that will prompt the user for the price of the candy and the amount of money she would like to spend and then calculates and display the amount of candies that can be purchased.
             */

            // INPUT
            int candyPrice;
            int money;

            //OUTPUT 
            int candyAmount;

            // ALGORITHM
            Console.Write("Please enter the price of candy: ");
            candyPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The price of candy is " + candyPrice);

            Console.Write("Enter money you would like to spend: ");
            money = Convert.ToInt32(Console.ReadLine());

            candyAmount = candyPrice / money;
            Console.WriteLine($"You can purchase {candyAmount} candies.");
            
        }
    }
}

using System;
using static System.Console;

namespace Exercise5_Gerard_The_Plumber {
    class Program {
        static void Main(string[] args) {
            /*
             * Gerard-The Plumber bills customers by the length of the pipe as well as the number of joins that is needed. Write a program that prompts the user for the length of the pipe, the number of joins and the unit price per length and joins. The program calculates and displays the total cost of the job. You may use the inputs in checking your program. (length of pipe = 4m, price per meter = $1.25, number of joins = 5, price per join = $1.20. The total cost of the job will be $11.00)
             */

            // INPUT
            int length;
            double pricePerMeter;
            int numOfJoins;
            double pricePerJoin;

            Write("Length of pipe: ");
            length = Convert.ToInt32(ReadLine());

            Write("Price per meter: ");
            pricePerMeter = Convert.ToDouble(ReadLine());

            Write("Number of joins required: ");
            numOfJoins = Convert.ToInt32(ReadLine());

            Write("Price per join: ");
            pricePerJoin = Convert.ToDouble(ReadLine());

            // OUTPUT
            double costOfJob;

            // ALGORITHM
            costOfJob = (length * pricePerMeter) + (numOfJoins * pricePerJoin);
            Console.WriteLine("The total cost will be " + costOfJob.ToString("C"));
        }

    }
}

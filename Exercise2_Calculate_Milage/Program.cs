using System;

namespace Exercise2_Calculate_Milage {
    class Program {
        static void Main(string[] args) {
            /*
              * When Jacob Steinberg began his trip to California, he filled his car’s tank with gas and reset his trip meter to zero. After traveling some distance, Jacob stopped at a gas station to refuel; the gas tank required fuel. Create a program that Jacob can use to display his car gas mileage – the number of miles his can be driven per gallon of gas.  [Assume that the distance travelled is 324 miles and the fuel used is 17 gallons then the mileage will be 19.] 
             */

            // INPUT
            int gas = 17;
            int distance= 324;

            // OUTPUT
            int mileage;

            // ALGORITHM
            mileage = distance / gas;
            Console.WriteLine($"Gas: {gas} gallons");
            Console.WriteLine($"Distance Travelled: {distance} miles");
            Console.WriteLine($"Your mileage is {mileage} per gallon.");

        }
    }
}

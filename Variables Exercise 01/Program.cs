using System.Collections.Generic;
using System;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts

            const int myAge = 24;
            const double price = 24.99D;
            const string myName = "Joel";

            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            string myPet = "Decker";
            char myFavoriteLetter = 'F';
            bool favoritePizza = true;
            int catAge = 115;
            double price2 = 15.99D;
            decimal myGDP = 1.234431M;


            // TODO: Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console

            Console.WriteLine(myPet);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(favoritePizza);
            Console.WriteLine(catAge);
            Console.WriteLine(price2);
            Console.WriteLine(myGDP);
        }

    }
}

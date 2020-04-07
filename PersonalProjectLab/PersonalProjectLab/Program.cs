using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                //Prompt the user to indicate which type of spraying they wish to calculate
                Console.WriteLine("Enter 1 for crop dusting quote or 2 for ground spraying quote");
                string spray = Console.ReadLine();
                // If they select crop dusting
                if (spray == "1")
                {
                    string input = "";
                    int CostofSpraying = 0;
                    int NumberofAcres = 0;
                    int TypeofPesticide = 0;
                       
                    //Prompt the user to enter the cost of spraying per acre, # of acres, typre of pesticide
                    Console.WriteLine("Enter the cost of spraying per acre");
                    input = Console.ReadLine();
                    CostofSpraying = int.Parse(input);

                    Console.WriteLine("Enter the number of acres being sprayed");
                    input = Console.ReadLine();
                    NumberofAcres = int.Parse(input);

                    Console.WriteLine("Enter the cost of the pesticide");
                    input = Console.ReadLine();
                    TypeofPesticide = int.Parse(input);

                    //Calculate the cost of spraying with this method
                    CropSpraying price = new CropSpraying();

                    int avg = price.CalculateCropDustingPrice(CostofSpraying, NumberofAcres, TypeofPesticide );
                    // Write the cost of spraying with this method
                    Console.WriteLine("The cost to crop dust your land is " + avg);
                }
                
                //Else is the user enters ground sprayer
                else if (spray == "2")
                {
                    string input = "";
                    int CostofSpraying = 0;
                    int NumberofAcres = 0;
                    int TypeofPesticide = 0;

                    //Prompt user to enter the cost of spraying per acre, # of acres, and type of pesticide
                    Console.WriteLine("Enter the cost of spraying per acre");
                    input = Console.ReadLine();
                    CostofSpraying = int.Parse(input);

                    Console.WriteLine("Enter the number of acres being sprayed");
                    input = Console.ReadLine();
                    NumberofAcres = int.Parse(input);

                    Console.WriteLine("Enter the cost of the pesticide");
                    input = Console.ReadLine();
                    TypeofPesticide = int.Parse(input);

                    //Calculate the cost of spraying with this method
                    CropSpraying groundprice = new CropSpraying();

                    int avg = groundprice.CalculateGroundDustingPrice(CostofSpraying, NumberofAcres, TypeofPesticide);
                    //Write the cost of spraying with this method
                    Console.WriteLine("The cost to ground spray your land is " + avg);
                }

            
                //Prompt the user to see if they want to calculate the other cost
                //If yes, then return to the top of the program

                Console.WriteLine("Enter Y for cost of other option or N to quit");
                string anotherspray = Console.ReadLine();

                if (anotherspray == "N")
                {
                    //else the program ends
                    shouldContinue = false;
                }


            }

            Console.WriteLine("Thanks for budgeting your crops with Midwest AG");
            
        }
    }
}
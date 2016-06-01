using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Switch_propgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCofeeCost = 0;

            //This label will help initialize it
            Choices:
            Console.WriteLine("Please Select your coffee size :  1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());



            switch (UserChoice)
            {
                case 1:
                    TotalCofeeCost += 1;
                    break;
                case 2:
                    TotalCofeeCost += 2;
                    break;
                case 3:
                    TotalCofeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto Choices;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Choices;
                case "NO":
                    break;
                default:
                    Console.WriteLine("That choice {0} is invalid. Plese type Yes or No", UserDecision);
                    goto Decide;
            }


            Console.WriteLine("Tank you for shoping with us!");
            Console.WriteLine("Your Total Amount = {0}", TotalCofeeCost);


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
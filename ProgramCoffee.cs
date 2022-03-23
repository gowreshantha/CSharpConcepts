using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    /// <summary>
    /// A Simple Program for Coffee
    /// </summary>
    public class ProgramCoffee
    {
        public static void CoffeeProcess()
        {
            string userChoice = "";
            int userCoffee = -1;
            int BillAmount = 0;
            do
            {
       
                do
                {
                    Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large ");
                    userCoffee = int.Parse(Console.ReadLine());

                    switch (userCoffee)
                    {
                        case 1:
                            BillAmount += 1;
                            break;
                        case 2:
                            BillAmount += 2;
                            break;
                        case 3:
                            BillAmount += 3;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice {0} ",userCoffee);
                            break;
                    }
                } while (userCoffee != 1 && userCoffee != 2 && userCoffee != 3);

                do
                {

                    Console.WriteLine("Do you want to buy another coffee - Yes or No");
                    userChoice = Console.ReadLine();

                    if(userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO")
                    {
                        Console.WriteLine("Your Choice {0} is invalid. Please try again... ",userChoice);
                    }

                } while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");


            } while (userChoice.ToUpper() == "YES");
            Console.WriteLine("Thank you for Shopping with Us!");
            Console.WriteLine("Your Total Bill is = {0}",BillAmount);
        }
    }
}

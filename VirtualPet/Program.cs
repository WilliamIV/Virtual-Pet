using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Artwork
            Console.WriteLine(",-.___,-.");
            Console.WriteLine("\\_/_ _\\_/");
            Console.WriteLine("  )O_O(");
            Console.WriteLine(" { (_) }");
            Console.WriteLine("  `-^-'");
            Console.WriteLine();

            //Name the pet
            Console.WriteLine("Name your husky.");
            string userNameInput = (Console.ReadLine());

            //Instrustions
            Console.WriteLine("\nYour mission is to take care of " + userNameInput + ", making sure she eats, drinks, and gets some play time. \n\nSelect from the list below to monitor her needs, and keep her healthy, happy \nand the best dog she can be! ");

            PetAction nutrition = new PetAction();
            nutrition.feedDog = 50;
            Console.WriteLine(userNameInput + "'s food level is " + nutrition.feedDog);

            PetAction hydration = new PetAction();
            hydration.waterDog = 50;
            Console.WriteLine(userNameInput + "'s water level is " + hydration.waterDog);

            PetAction petToy = new PetAction();
            petToy.toyDog = 50;
            Console.WriteLine(userNameInput + "'s playfulness level is " + petToy.toyDog);

            Console.WriteLine();

            Console.WriteLine("Please select 1, 2, or 3.");

            for (;;)
            {
                int userNumber = int.Parse(Console.ReadLine());

                switch (userNumber)
                {
                    case 1:
                        Console.WriteLine(userNameInput + "'s food level is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s water level is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happiness is " + petToy.GiveGift());
                        break;

                    case 2:
                        Console.WriteLine(userNameInput + "'s food level is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s water level is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happiness is " + petToy.GiveGift());
                        break;

                    case 3:
                        Console.WriteLine(userNameInput + "'s food level is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s water level is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happiness is " + petToy.GiveGift());
                        break;

                    default:
                        Console.WriteLine("Invalid number choice.\nPlease select 1, 2, or 3.");
                        break;

                }


            }




        }
    }
}

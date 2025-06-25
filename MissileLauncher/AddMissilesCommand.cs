using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;

namespace MissileLauncher
{
    public class AddMissilesCommand : IMenuCommand
    {
        public void Execute()
        {
            Console.WriteLine("Which Missile would you want to add? the options are: Torpedo, Balistic, Cruise");
            string missileTypeInput = Console.ReadLine();

            if (Enum.TryParse(missileTypeInput.ToLower(), true, out MissileType missileType))
            {
                Console.WriteLine("how many would you want to add?");
                string quantityInput = Console.ReadLine();
                if (int.TryParse(quantityInput, out int quantity) && quantity > 0)
                {
                    Console.WriteLine($"Adding {quantity} {missileType} missiles to the inventory.");
                    

                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid missile type. Please try again.");
            }

        }
    }
}

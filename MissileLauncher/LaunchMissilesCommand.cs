using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;

namespace MissileLauncher
{
    public class LaunchMissilesCommand : IMenuCommand
    {
        private readonly IMissileLauncher _missileLauncher;

        public LaunchMissilesCommand(MissileLauncher missileLauncher)
        {
            _missileLauncher = missileLauncher;
        }

        public void Execute()
        {
            Console.WriteLine("which wype of missile would you want to fire, if you want to go cowabunga write: \"TotalWar\"");
            string missileTypeInput = Console.ReadLine();
            if (missileTypeInput.Equals("TotalWar", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Cowabunga! Launching all missiles in a spectacular display of firepower!");

            }
            else
            {
                Console.WriteLine($"How many missles would you want to fire?");
                string quantityInput = Console.ReadLine();
                if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive integer.");
                }
                else
                {
                    Console.WriteLine($"Launching {quantity} {missileTypeInput} missiles.");
                }
            }

        }
    }
}

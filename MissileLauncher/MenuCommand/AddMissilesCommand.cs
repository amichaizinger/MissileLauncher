using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    public class AddMissilesCommand : IMenuCommand
    {
        private readonly IMissileBattery _missileLauncher;
        public AddMissilesCommand(IMissileBattery missileBattery)
        {
            _missileLauncher = missileBattery ?? throw new ArgumentNullException(nameof(missileBattery));
        }
        public void Execute()
        {
            Console.WriteLine("Which Missile would you want to add? the options are: ");
            foreach (var type in _missileLauncher.MissileTypes.Keys)
            {
                Console.WriteLine($"- {type}");
            }

            string missileTypeInput = Console.ReadLine();

            if (_missileLauncher.MissileTypes.ContainsKey(missileTypeInput))
            {
                Console.WriteLine("how many would you want to add?");
                string quantityInput = Console.ReadLine();
                if (int.TryParse(quantityInput, out int quantity) && quantity > 0)
                {
                    IMissile missile = _missileLauncher.MissileTypes[missileTypeInput].GetMissile();

                    Console.WriteLine($"Adding {quantity} {missileTypeInput} missiles to the inventory.");
                    _missileLauncher.AddMissiles(missile, quantity);
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

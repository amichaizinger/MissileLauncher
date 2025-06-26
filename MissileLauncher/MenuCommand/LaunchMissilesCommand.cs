using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    public class LaunchMissilesCommand : IMenuCommand
    {
        private readonly IMissileBattery _missileBattery;

        public LaunchMissilesCommand(IMissileBattery missileBattery)
        {
            _missileBattery = missileBattery;
        }

        public void Execute()
        {
            int launchedCount = 0;

            Console.WriteLine("which type of missile would you want to fire (Torpedo, Balistic, Cruise), if you want to go cowabunga write: \"TotalWar\"");
            string missileTypeInput = Console.ReadLine();
            if (missileTypeInput.Equals("TotalWar", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Cowabunga! Launching all missiles in a spectacular display of firepower!");
                foreach (var missile in _missileBattery.missiles.ToList()) // running on a replia because you cant remove while on a list
                {
                    if (missile.IsActive)
                    {
                        bool success = missile.LaunchTechnic.Launch();
                        if (success)
                        {
                            launchedCount++;
                            _missileBattery.missiles.Remove(missile);
                        }
                        else
                        {
                            missile.IsActive = false;
                        }
                    }
                }
            }
            else if (_missileBattery.MissileTypes.ContainsKey(missileTypeInput))

            {
                Console.WriteLine($"How many missles would you want to fire?");
                string quantityInput = Console.ReadLine();
                if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive integer.");
                }
                else
                {
                    Console.WriteLine($"Trying to launching {quantity} {missileTypeInput} missiles.");

                    while (quantity > 0)
                    {
                        IMissile missile = _missileBattery.missiles.FirstOrDefault(m => m.Name == missileTypeInput && m.IsActive);
                        if (missile == null)
                        {
                            break;
                        }
                        bool success = missile.LaunchTechnic.Launch();
                        if (success)
                        {
                            launchedCount++;
                            _missileBattery.missiles.Remove(missile);
                            quantity--;
                        }
                        else
                        {
                            missile.IsActive = false;
                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid missile type. Please try again.");
                return;
            }
            Console.WriteLine($"Launched {launchedCount} missiles");
        }
    }
}

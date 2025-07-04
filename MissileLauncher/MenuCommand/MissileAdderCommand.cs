﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    public class MissileAdderCommand : IMenuCommand
    {
        private readonly IMissileBattery _missileBattery;
        public MissileAdderCommand(IMissileBattery missileBattery)
        {
            _missileBattery = missileBattery ?? throw new ArgumentNullException(nameof(missileBattery));
        }
        public void Execute()
        {
            Console.WriteLine("Which Missile would you want to add? the options are: ");
            foreach (var type in _missileBattery.MissileTypes.Keys)
            {
                Console.WriteLine($"- {type}");
            }

            string missileTypeInput = Console.ReadLine();

            if (_missileBattery.MissileTypes.ContainsKey(missileTypeInput))
            {
                Console.WriteLine("how many would you want to add?");
                string quantityInput = Console.ReadLine();
                if (int.TryParse(quantityInput, out int quantity) && quantity > 0)
                {
                    IMissile missile = _missileBattery.MissileTypes[missileTypeInput].GetMissile();

                    Console.WriteLine($"Adding {quantity} {missileTypeInput} missiles to the inventory.");
                    _missileBattery.AddMissiles(missile, quantity);
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

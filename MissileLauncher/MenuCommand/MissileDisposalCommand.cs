using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    internal class MissileDisposalCommand : IMenuCommand
    {
        private IMissileBattery _missileBattery;

        public MissileDisposalCommand(IMissileBattery missileBattery)
        {
            _missileBattery = missileBattery;
        }
        public void Execute()
        {
            Console.WriteLine($"enter the place of the missile you want to dispose of from 0 to {_missileBattery.missiles.}");
            string input = Console.ReadLine();

        }
    }
}

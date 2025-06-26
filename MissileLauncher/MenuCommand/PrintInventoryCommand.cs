using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    public class PrintInventoryCommand : IMenuCommand
    {
        private IMissileBattery _missileBattery;
        public PrintInventoryCommand(IMissileBattery missileBattery)
        {
            _missileBattery = missileBattery;
        }
        public void Execute()
        {
            Console.WriteLine($"There are {_missileBattery.missiles.Count} missiles in the inventory");
            Console.WriteLine("the missiles by order are:");
            for (int i = 0; i < _missileBattery.missiles.Count; i++)
            {
                var missile = _missileBattery.missiles[i];
                Console.WriteLine($"{i}: {missile.Name}");
            }
        }
    }
}

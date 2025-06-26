using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder;
using MissileLauncher.Interfaces;

namespace MissileLauncher.MenuCommand
{
    public class MissileDisposalCommand : IMenuCommand
    {
        private IMissileBattery _missileBattery;

        public MissileDisposalCommand(IMissileBattery missileBattery)
        {
            _missileBattery = missileBattery;
        }
        public void Execute()
        {
            if(_missileBattery.missiles.Count == 0)
            {
                Console.WriteLine("There are no missiles to dispose of.");
                return;
            }
            Console.WriteLine($"enter the place of the missile you want to dispose of from 0 to {_missileBattery.missiles.Count-1}");
            string indexInput = Console.ReadLine();
            if( !int.TryParse(indexInput, out int index) || index > _missileBattery.missiles.Count-1)
            {
                Console.WriteLine("Invalid index. Please enter a valid index.");
            }
            else
            {
                _missileBattery.missiles.RemoveAt(index);
            }
            

        }
    }
}

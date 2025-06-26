using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher.Missiles
{
    public class Balistic : IMissile
    {
        public string Name { get; private set; }

        public ILaunchTechnic LaunchTechnic { get; private set; }

        public bool IsActive { get; set; } = true;

        public Balistic(ILaunchTechnic launchTechnic, string name)
        {
            LaunchTechnic = launchTechnic;
            Name = name;
        }

        public IMissile GetMissile()
        {
            return new Balistic(LaunchTechnic, Name);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher.Missiles
{
    public class Cruise : IMissile
    {
        public ILaunchTechnic LaunchTechnic { get; private set; }

        public bool IsActive { get; private set; } = true;

        public Cruise(ILaunchTechnic launchTechnic)
        {
            LaunchTechnic = launchTechnic;
        }

        public IMissile GetMissile()
        {
            return new Cruise(LaunchTechnic);
        }

        public double GetSuccessRate()
        {
            return LaunchTechnic.GetSuccessRate();
        }
    }
}

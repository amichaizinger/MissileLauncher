using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher.Missiles
{
    public class Torpedo : IMissile
    {
        public ILaunchTechnic LaunchTechnic { get; private set; }

        public bool IsActive { get; private set; } = true;

        public Torpedo(ILaunchTechnic launchTechnic)
        {
            LaunchTechnic = launchTechnic;
        }

        public IMissile GetMissile()
        {
            return new Torpedo(LaunchTechnic);
        }

        public double GetSuccessRate()
        {
            return LaunchTechnic.GetSuccessRate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher
{
    public interface IMissile
    {
        ILaunchTechnic LaunchTechnic { get; }
        bool IsActive { get; }
        public IMissile GetMissile();
        public double GetSuccessRate()
        {
            return LaunchTechnic.GetSuccessRate();

        }
    }
}

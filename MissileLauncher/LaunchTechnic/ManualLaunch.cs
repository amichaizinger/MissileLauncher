using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher.LaunchTechnic
{
    public class ManualLaunch : ILaunchTechnic //used for balistic missiles
    {
        public double GetSuccessRate()
        {
            return 0.5;
        }
    }
}

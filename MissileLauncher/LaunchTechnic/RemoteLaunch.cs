using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher.LaunchTechnic
{
    internal class RemoteLaunch : ILaunchTechnic //used for cruise missiles
    {
        public double GetSuccessRate()
        {
            return 0.2;
        }
    }

}

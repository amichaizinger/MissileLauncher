using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileLauncher
{
    public class LegendaryLaunch : ILaunchTechnic //used for Torpedo missiles
    {
        public double GetSuccessRate()
        {
            return 1; 
        }
    }
}

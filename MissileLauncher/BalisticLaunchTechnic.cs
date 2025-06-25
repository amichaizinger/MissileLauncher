using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileLauncher
{
    public class BalisticLaunchTechnic : ILaunchTechnic //used for balistic missiles
    {
        public double GetSuccessRate()
        {
            return 0.5;
        }
    }
}

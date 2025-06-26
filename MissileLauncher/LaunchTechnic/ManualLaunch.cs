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
        public bool Launch()
        {
            // 50% success rate
            Random random = new Random();
            int number = random.Next(10) + 1;
            if (number < 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

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
        public bool Launch()
        {
            //20% success rate
            Random random = new Random();
            int number = random.Next(10) + 1;
            if (number < 3)
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

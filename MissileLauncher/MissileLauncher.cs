using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileLauncher
{
    public class MissileLauncher : IMissileLauncher
    {
        private List<MissileType> missileBattery = new List<MissileType>();

        public void AddMissiles(MissileType missileType, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                missileBattery.Add(missileType);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileLauncher
{
    public interface IMissileLauncher
    {
        public void AddMissiles(MissileType missileType, int quantity);

    }
}

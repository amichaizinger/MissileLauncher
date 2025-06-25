using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Enums;

namespace MissileLauncher.Interfaces
{
    public interface IMissileLauncher
    {
        public void AddMissiles(Enums.IMissile missileType, int quantity);

    }
}

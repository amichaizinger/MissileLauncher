using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileLauncher.Interfaces
{
    public interface IMissileBattery
    {
        List<IMissile> missiles { get; }
        Dictionary<string, IMissile> MissileTypes { get; set; }

        public void AddMissileType(string name, IMissile missile);
        public void AddMissiles(IMissile missile, int quantity);
        public void LaunchAllMissiles();
        public void LaunchMissiles();

    }
}

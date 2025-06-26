using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher
{
    public class MissileBattery : IMissileBattery
    {
        public List<IMissile> missiles { get; private set; } = new List<IMissile>();
        public Dictionary<string, IMissile> MissileTypes { get; set; } = new Dictionary<string, IMissile>();


        public void AddMissileType(string name, IMissile missile)
        {
            if (!MissileTypes.ContainsKey(name))
            {
                MissileTypes[name] = missile;
            }
        }
        public void AddMissiles(IMissile missile, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                missiles.Add(missile);
            }
        }

        public void LaunchMissiles()
        {

        }
    }
}

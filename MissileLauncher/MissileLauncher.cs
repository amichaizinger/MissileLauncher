using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Enums;
using MissileLauncher.Interfaces;

namespace MissileLauncher
{
    public class MissileLauncher : IMissileLauncher
    {
        private List<IMissile> missiles = new List<IMissile>();
        private Dictionary<string, IMissile> MissileTypes = new Dictionary<string, IMissile>();

        public void AddMissileType(string name, IMissile missile)
        {
            if (!MissileTypes.ContainsKey(name))
            {
                MissileTypes[name] = missile;
            }
        }
        public void AddMissiles(Enums.IMissile missile, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                missiles.Add(missile);
            }
        }
        public void FireAllMissiles()
        {

        }
        public void FireMissiles()
        {

        }
    }
}

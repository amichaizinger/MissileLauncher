using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileLauncher.Interfaces;

namespace MissileLauncher
{
    public interface IMissile
    {
        public string Name { get; }
        ILaunchTechnic LaunchTechnic { get; }
        bool IsActive { get; set; }
        public IMissile GetMissile();
    }
}

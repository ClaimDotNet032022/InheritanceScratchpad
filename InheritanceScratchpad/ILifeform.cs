using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public interface ILifeform
    {
        bool IsAlive { get; }

        ILifeform Reproduce();

        void Die();
    }
}

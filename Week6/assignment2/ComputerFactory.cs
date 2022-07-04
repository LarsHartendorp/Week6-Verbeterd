using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public abstract class ComputerFactory
    {
        public abstract IHardDisk MakeHardDisk(); 
        public abstract IProcessor MakeProcessor();
        public abstract IMonitor MakeMonitor();
    }
}

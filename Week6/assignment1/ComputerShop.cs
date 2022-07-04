using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class ComputerShop
    {
        public Computer AssembleComputer() 
        {
            Computer computer = new Computer();
            computer.Processor = MakeProcessor();
            computer.HardDisk = MakeHardDisk();
            computer.Monitor = MakeMonitor();
            
            return computer;
        }

        public abstract IProcessor MakeProcessor();

        public abstract IHardDisk MakeHardDisk();

        public abstract IMonitor MakeMonitor();


    }
}

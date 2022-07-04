using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    // Factory of factories
    public class ComputerShop
    {
        private ComputerFactory factory;

        public ComputerShop(ComputerFactory factory)
        {
            this.factory = factory;
        }

        public Computer AssembleComputer() 
        {
            //return this.factory.AssembleComputer();
            return new Computer()
            {
                HardDisk = this.factory.MakeHardDisk(),
                Monitor = this.factory.MakeMonitor(),
                Processor = this.factory.MakeProcessor()
            };
        }
    }
}

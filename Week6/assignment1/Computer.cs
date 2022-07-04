using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Computer
    {
        // constructor 
        public Computer()
        {
        }

        //3 properties
        public IProcessor Processor { get; set; }
        public IHardDisk HardDisk { get; set; }
        public IMonitor Monitor { get; set; }

        // methods
        public void Test() 
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}

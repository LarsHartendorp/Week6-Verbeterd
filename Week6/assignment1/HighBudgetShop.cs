using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class HighBudgetShop : ComputerShop
    {
        public override IHardDisk MakeHardDisk()
        {
            return new HighBudgetHD();

        }

        public override IMonitor MakeMonitor()
        {
            return new HighBudgetMonitor();
        }

        public override IProcessor MakeProcessor()
        {
            return new HighBudgetProcessor();
        }
    }
}

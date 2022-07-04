﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class LowBudgetShop : ComputerShop
    {
        public override IHardDisk MakeHardDisk()
        {
            return new LowBudgetHD();
        }

        public override IMonitor MakeMonitor()
        {
            return new LowBudgetMonitor();
        }

        public override IProcessor MakeProcessor()
        {
            return new LowBudgetProcessor();
        }
    }
}

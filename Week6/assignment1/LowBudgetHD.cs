﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class LowBudgetHD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data not so quickly...");
        }
    }
}

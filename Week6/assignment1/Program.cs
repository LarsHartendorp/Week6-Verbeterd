using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            HighBudgetShop hbShop = new HighBudgetShop();
            Computer highBudget = hbShop.AssembleComputer();
            highBudget.Test();
            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            LowBudgetShop lbShop = new LowBudgetShop();
            Computer lowBudget = lbShop.AssembleComputer();
            lowBudget.Test();
        }

    }
}

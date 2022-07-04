using System;

namespace assignment2
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
            ComputerFactory highBudget = new HighBudgetFactory();
            ComputerShop computerShop = new ComputerShop(highBudget);
            Computer highEnd = computerShop.AssembleComputer();
            highEnd.Test();
            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory lowBudget = new LowBudgetFactory();
            computerShop = new ComputerShop(lowBudget);
            Computer lowEnd = computerShop.AssembleComputer();
            lowEnd.Test();

            Console.ReadKey();
        }
    }
}

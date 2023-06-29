using MyWarehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse.Strategies
{
    internal class CommandLineStrategyResolver : ICommandLineStrategyResolver
    {
        public ICommandLineStrategy GetResolver(ConsoleKey consoleKey)
        {
            if (consoleKey == ConsoleKey.A)
            {
                return new GetProductsStrategy();
            }
            else if (consoleKey == ConsoleKey.B)
            {
                return new AddProductStrategy();
            }
            else if (consoleKey == ConsoleKey.C)
            {
                return new SellProductStrategy();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}

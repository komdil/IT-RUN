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
        IEnumerable<ICommandLineStrategy> _strategies;
        public CommandLineStrategyResolver(IEnumerable<ICommandLineStrategy> strategies)
        {
            _strategies = strategies;
        }

        public ICommandLineStrategy GetResolver(ConsoleKey consoleKey)
        {
            return _strategies.Single(s => s.StrategyKey == consoleKey);
        }
    }
}

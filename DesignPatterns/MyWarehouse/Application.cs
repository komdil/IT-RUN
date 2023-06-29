using MyWarehouse.Repositories;
using MyWarehouse.Repositories.Abstractions;
using MyWarehouse.Strategies;
using MyWarehouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse
{
    public class Application
    {
        ICommandLineStrategyResolver _resolver;
        public Application(ICommandLineStrategyResolver commandLineStrategy)
        {
            _resolver = commandLineStrategy;
        }

        public void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();
                ShowMenu();

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                var strategy = _resolver.GetResolver(userInput.Key);
                strategy.Execute();

                Console.WriteLine("Нажмите для продолжения.");
                Console.ReadKey();
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("Выберите действие: \n" +
                "а) Показать список продуктов\n" +
                "b) Добавить новый продукт\n" +
                "c) Продать продукт\n" +
                "ESC) Выйти из программы\n");
        }
    }
}

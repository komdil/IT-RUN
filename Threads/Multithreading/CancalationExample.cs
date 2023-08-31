using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class CancalationExample
    {
        public static void Start()
        {
            CancellationTokenSource cancellationTokenSource = new();
            //cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(10));

            var products = new List<string> { "Apple", "Banana", "Cherry", "Apple", "Banana", "Cherry" };
            Task task = new Task(() => WriteProductCount(products, default));
            task.Start();
            var text = Console.ReadLine();
            if (text == "Cancel")
            {
                cancellationTokenSource.Cancel();
            }
        }

        static void WriteProductCount(List<string> products, CancellationToken cancellationToken)
        {
            foreach (var product in products)
            {
                cancellationToken.ThrowIfCancellationRequested();
                //send request to two apis and get count
                Task.Delay(2000).Wait();
            }
        }
    }
}

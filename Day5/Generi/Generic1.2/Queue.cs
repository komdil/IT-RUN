namespace GenericExamples
{
    public class Queue
    {
        public BankClient[] Items { get; set; }

        public Queue(int maxLenght)
        {
            Items = new BankClient[maxLenght];
        }

        public void ShowQueue()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                var item = Items[i];

                Console.WriteLine($"Number: {item?.Number}, Price:{item?.PriceOfSupport}");
            }
        }

        public void AddToQueue(BankClient number)
        {
            //TODO: number should not be 0
            for (int i = 0; i < Items.Length; i++)
            {
                BankClient item = Items[i];
                if (item == null)
                {
                    Items[i] = number;
                    break;
                }
            }
        }

        public void MakeService()
        {
            var itemInQueue = Items[0];
            Console.WriteLine($"Price for service: {itemInQueue.PriceOfSupport}");
            for (int i = 0; i < Items.Length - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
            Items[Items.Length - 1] = null;
        }
    }
}

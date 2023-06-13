using Generic1._3;

namespace GenericExamples
{
    public class Queue<T> where T : class, IQueuItem
    {
        public T[] Items { get; set; }

        public Queue(int maxLenght)
        {
            Items = new T[maxLenght];
        }

        public void ShowQueue()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                var item = Items[i];

                Console.WriteLine($"Number: {item?.Number}, Price:{item?.PriceOfSupport}");
            }
        }

        public void AddToQueue(T number)
        {
            //TODO: number should not be 0
            for (int i = 0; i < Items.Length; i++)
            {
                T item = Items[i];
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
            itemInQueue.Number = 0;
            Console.WriteLine($"Price for service: {itemInQueue.PriceOfSupport}");
            for (int i = 0; i < Items.Length - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
            Items[Items.Length - 1] = null;
        }
    }
}

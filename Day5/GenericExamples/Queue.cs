namespace GenericExamples
{
    public class Queue
    {
        public int[] Items { get; set; }

        public Queue(int maxLenght)
        {
            Items = new int[maxLenght];
        }

        public void ShowQueue()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }

        public void AddToQueue(int number)
        {
            //TODO: number should not be 0
            for (int i = 0; i < Items.Length; i++)
            {
                int item = Items[i];
                if (item == 0)
                {
                    Items[i] = number;
                    break;
                }
            }
        }

        public void MakeService()
        {
            var itemInQueue = Items[0];
            Console.WriteLine("Price for service: ");
            for (int i = 0; i < Items.Length - 1; i++)
            {
                Items[i] = Items[i + 1];
            }
            Items[Items.Length - 1] = 0;
        }
    }
}

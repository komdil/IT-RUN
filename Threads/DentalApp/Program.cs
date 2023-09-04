using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        _ = CheckHardware();
        _ = CheckDriver();
        Console.ReadLine();
    }

    static bool IsConnected()
    {
        return false;
    }

    static async Task CheckHardware()
    {
        while (!IsConnected())
        {
            await Task.Delay(10);
        }
        EnableButton();
    }

    static async Task CheckDriver()
    {
        while (!IsConnected())
        {
            await Task.Delay(10);
        }
        EnableButton();
    }

    static void EnableButton()
    {

    }
}
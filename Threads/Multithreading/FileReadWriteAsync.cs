using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class FileReadWriteAsync
    {
        public static async Task Start()
        {
            var readFileTask = ReadFile("1.txt");//10second
            var writeFileTask = WriteToFile("2.txt");//15 second
            await Task.WhenAll(readFileTask, writeFileTask);
            Console.WriteLine(readFileTask.Result);//15 second
        }

        private static async Task<string> ReadFile(string path)
        {
            return await File.ReadAllTextAsync(path);
        }

        private static async Task WriteToFile(string path)
        {
            await File.WriteAllTextAsync(path, "Hello");
        }
    }
}

// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

[MemoryDiagnoser]
[RankColumn]
class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<BenchmarkDiagnose>();
    }
}


public class BenchmarkDiagnose
{
    private int number = 10;
    private int maxSize = 10;
    public static string Generate(int number, int maxSize)
    {
        string result = "";

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= maxSize; j++)
            {
                result += $"{i}x{j}={i * j}";
                result += "\n";
            }
        }
        return result;
    }
    [Benchmark]
    public string TestBenchmark()
    {
        return Generate(number, maxSize);
    }

    [Benchmark]
    public string TestBenchmarkWithStringBuilder()
    {
        return GenerateWithStringBuilder(number, maxSize);
    }
    public static string GenerateWithStringBuilder(int number, int maxSize)
    {
        var result = new StringBuilder();

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= maxSize; j++)
            {
                result.Append($"{i}x{j}={i * j}\n");
            }
        }
        return result.ToString();
    }
}
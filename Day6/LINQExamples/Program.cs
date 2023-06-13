using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections;
using LINQExamples;

FirstExample.RunExample();

List<string> students = new List<string>()
{
    "Student1",
    //"Student2",
    //"Student3",
    //"Student1",
};


IEnumerable<string> myrequest = students.Where(s => s.StartsWith("Student"));


students.Add("Student2");

foreach (string item in myrequest)
{
    Console.WriteLine(item);
}


var product = new Product();
product.Exists();

foreach (var item in product)
{

}

// See https://aka.ms/new-console-template for more information
Console.ReadLine();


class Product : IEnumerable<int>
{
    public int Count { get; set; }
    public string Name { get; set; }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return i;
        }
    }
}

static class Extensions
{
    public static bool Exists(this Product product)
    {
        return true;
    }
}
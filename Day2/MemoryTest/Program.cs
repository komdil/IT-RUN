// See https://aka.ms/new-console-template for more information

using MemoryTest;

int intfive = 5;

object objFive = intfive;

int intFive2 = 5;
object objFive2 = intFive2;

bool isIntEqual = intfive == intFive2;
Console.WriteLine(isIntEqual);

bool isObjEqual = objFive == objFive2;
Console.WriteLine(isObjEqual);
Console.Read();











//bool result = int.TryParse("abc", out int number2);
//string numberStr = "1234";

//int number = 10;//8byte
//Plus(ref number);
//Console.WriteLine(number);
//Console.Read();



//void Plus(ref int number)
//{
//    number++;
//}

//bool TryGetExistingProduct(string[] products, string productName, out int count)
//{
//    count = 0;
//    var product = products.FirstOrDefault(s => s.Contains(productName));
//    if (product != null)
//    {
//        count = int.Parse(product.Split(' ')[1]);
//        return true;
//    }
//    GC.Collect();
//    return false;
//}

//Student student = new Student();
//Backpack backpack = new Backpack();
//backpack.Student = student;



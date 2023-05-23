// See https://aka.ms/new-console-template for more information

void Code1()
{
    int intfive = 5;
    object objFive = intfive;

    int intFive2 = 5;
    object objFive2 = intFive2;

    bool isIntEqual = intfive == intFive2;
    Console.WriteLine(isIntEqual);

    bool isObjEqual = objFive == objFive2;
    Console.WriteLine(isObjEqual);
}

void Code2()
{
    string strfive = "5";
    object objFive = strfive;

    string strFive2 = "5";
    object objFive2 = strFive2;

    bool isIntEqual = strfive == strFive2;
    Console.WriteLine(isIntEqual);

    bool isObjEqual = objFive == objFive2;
    Console.WriteLine(isObjEqual);
}

void Code3()
{
    int x = 5;
    object o = x;
    x = 10;
    var y = (int)o;
    Console.WriteLine(y);
}

Console.ReadLine();

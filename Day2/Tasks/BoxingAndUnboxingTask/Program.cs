// See https://aka.ms/new-console-template for more information

void Code1()
{
    int intfive = 5;//Число 5 храниться в heap
    object objFive = intfive;// копируеться число 5 

    int intFive2 = 5;//Число 5 храниться в heap
    object objFive2 = intFive2;// копируеться число 5 

    bool isIntEqual = intfive == intFive2;
    Console.WriteLine(isIntEqual);//здес будет True, потому что 5 ровно 5

    bool isObjEqual = objFive == objFive2;
    Console.WriteLine(isObjEqual);//здес будет Folse, потому что objFive неровно objFive2
}

void Code2()
{
    string strfive = "5";//Число 5 храниться в heap
    object objFive = strfive;// копируеться число 5 


    string strFive2 = "5";//Число 5 храниться в heap
    object objFive2 = strFive2;// копируеться число 5

    bool isIntEqual = strfive == strFive2;
    Console.WriteLine(isIntEqual);//здес будет True, потому что 5 ровно 5


    bool isObjEqual = objFive == objFive2;
    Console.WriteLine(isObjEqual);//здес будет Folse, потому что objFive неровно objFive2
}

void Code3()
{
    int x = 5;//Число 5 храниться в Stack
    object o = x;//boxing
    x = 10;//х принимаеть новые значения как 10
    var y = (int)o;//Unboxing
    Console.WriteLine(y);
}

Console.ReadLine();

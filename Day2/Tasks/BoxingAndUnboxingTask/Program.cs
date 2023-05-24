// See https://aka.ms/new-console-template for more information

void Code1()
{
    int intfive = 5; // Declaring an integer variable and assigning the value 5 to it (stored in stack).
    object objFive = intfive; // Declaring an object and assigning the value of the variable 'intfive'. In other words, value of 'intfive' boxed and stored in the heap

    int intFive2 = 5; // Declaring an integer variable and assigning the value 5 to it (stored in stack).
    object objFive2 = intFive2; // Declaring an object and assigning the value of the variable 'intfive2'. In other words, value of 'intfive2' boxed and stored in the heap

    bool isIntEqual = intfive == intFive2; // Comparing the value of these two varibales, since both equal to 5 the output will be 'true'.
    Console.WriteLine(isIntEqual); // Output: true

    bool isObjEqual = objFive == objFive2; // since we comparing this two objects using '==' sign it compares the reference points of these two objects and gives 'false' as an output because they are refering to different memory locations
    Console.WriteLine(isObjEqual); // Output: false
}

void Code2()
{
    string strfive = "5"; // Declaring a string variable and assigning the value '5' to it and since the string is a reference type it is stored in heap
    object objFive = strfive; // Declaring an object (stored in heap) and assigning the value of the variable 'strfive'. We can not call it boxing since both string and object are reference type.

    string strFive2 = "5"; // Declaring a string variable and assigning the value '5' to it and since the string is a reference type it is stored in heap
    object objFive2 = strFive2; // Declaring an object (stored in heap) and assigning the value of the variable 'strfive2'. We can not call it boxing since both string and object are reference type.

    bool isIntEqual = strfive == strFive2; // This command checks the equality of two strings
    Console.WriteLine(isIntEqual); // Output: True

    bool isObjEqual = objFive == objFive2; // As a code in the first function (Code1) '==' sign compare the refences of these objects and both refere to the same memory location.
    Console.WriteLine(isObjEqual); // Output: True
}

void Code3()
{
    int x = 5; // Declaring variable x and assigning the value '5', stored in stack.
    object o = x; // Declaring an object and assigning the value of the variable 'x'. In other words, value of 'x' boxed and stored in the heap
    x = 10; // Updating the value of x to 10 (stored in stack)
    var y = (int)o; // Unboxing the value of object 'o' where we boxed it when x was 5 (stored in stack)
    Console.WriteLine(y); // Output: 5
}
Console.ReadLine();

//using Day5HomeWork;

//Menu Napitki = new Menu();
//Napitki.MenuName = "Napitki";

//Menu Chay = new Menu();
//Chay.MenuName = "Chay";

//Menu Sok = new Menu();
//Sok.MenuName = "Sok";

//Napitki.Childs = new Menu[2];
//Napitki.Childs[0] = Chay;
//Napitki.Childs[1] = Sok;

//MenuGenerator.GenerateMenu(Napitki);

using Day5HomeWork;

ComplexMenu google = new ComplexMenu();
google.MenuName = "Google";
google.Href = "https://google.com";

ComplexMenu somon = new ComplexMenu();
somon.MenuName = "Somon TJ";
somon.Href = "https://somon.tj";

ComplexMenu microsoft = new ComplexMenu();
microsoft.MenuName = "Microsoft";
microsoft.Href = "https://microsoft.com";

google.Childs = new ComplexMenu[2];
google.Childs[0] = somon;
google.Childs[1] = microsoft;

MenuGenerator.GenerateMenu(google);

var student = new Teacher();


IMenu<ComplexMenu> menu = new ComplexMenu();



class Person
{

}
class Teacher : Person
{

}
class Student : Person
{

}


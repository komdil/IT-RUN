// See https://aka.ms/new-console-template for more information
using OOPExamples;

//Console.WriteLine("Hello, World!");

Point Point = new Point() { X = 10, Y = 10 };
Point Point2 = new Point() { X = 5, Y = 5 };

Point differenceOfPoints = Point - Point2;

Point Point3 = new Point() { X = 5, Y = 5 };
Point Point4 = new Point() { X = 5, Y = 5 };
var result = Point3 == Point4;

Point mynewPoint = "Test";

Console.ReadLine();
EmployeeValidator employeeValidator = GetEmployeeValidator();

#region Task2

var service = GetEmployeeService();

var allEmployees = service.GetEmployees();
foreach (var empoyee in allEmployees)
{
    Console.WriteLine(empoyee);
}


#endregion

Console.ReadLine();

#region Task1

try
{
    while (true)
    {
        Console.WriteLine("Add email of employee");
        var employee = new Employee();

        employee.Email = Console.ReadLine();
        try
        {
            employeeValidator.Validate(employee);
        }
        catch (EmployeeValidationFailedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Unhundled exception:{ex}. Please contact customer support");
}


#endregion

static EmployeeValidator GetEmployeeValidator()
{
    return new EmployeeValidator();
}

static EmployeeService GetEmployeeService()
{
    return new EmployeeService();
}
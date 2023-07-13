// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using System.Linq;

class Programm
{
    static void Main(string[] args)
    {
        var studentsQuery = GetStudentQuery()
                                .Where(s => s.Name == "Dilshod");//1000 item
        ListStudentsWithLastName(studentsQuery, "Komilov");
    }

    static void ListStudentsWithLastName(IQueryable<Student> students, string lastName)
    {
        var listedStudents = students
            .Where(s => s.LastName == lastName).ToList();//100
    }

    static IQueryable<Student> GetStudentQuery()
    {
        return new List<Student>().AsQueryable();
    }
}

class Student
{
    public string Name { get; set; }

    public string LastName { get; set; }
}


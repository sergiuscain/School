using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class School
{
    public string Name;
    public List<Student> Students;
    public School(string Name)
    {
        this.Name = Name;
        Students = new List<Student>();
    }

    public void PrintStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("Список студентов пуст");
        }
        else
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine("{0, -10} {1, -10}", Students[i].FirstName, Students[i].LatestName);
            }
        }
    }

    public void AddNewStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Вы добавили студента {student}");
    }
}

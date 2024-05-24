using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    public string FirstName;
    public string LatestName;
    public int Id;
    public int Age;
    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LatestName = lastName;
        Age = age;
    }
}

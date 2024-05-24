Console.WriteLine("Здравствуйте! Введите название вашей школы");
string schoolName = Console.ReadLine();
School school = new School(schoolName);
Console.WriteLine($"Школа {school.Name} успешно создана");
while (true)
{
    Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "да")
    {
        Console.Clear();
        school.PrintStudents();
    }

    Console.WriteLine("Хотите добавить нового студента ?");
    userAnswer = Console.ReadLine();
    if (userAnswer =="да")
    {   
        Console.Clear();
        Console.WriteLine("Введите имя студента");
        string firstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию студента");
        string lastName = Console.ReadLine();

        Student student = new Student(firstName, lastName);
        school.AddNewStudent(student);
    }
    
}
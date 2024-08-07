public class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string lastname;
    public string LastName
    {
        get { return lastname; }
        set { lastname = value; }
    }
    private string birthDate;
    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public void LogInfoStudent()
    {
        Console.WriteLine($"Öğrencinin adı {name}, soyadı {lastname} ve doğum tarihi {birthDate}");
        Console.WriteLine("");
    }
    public void LogInfoTeacher()
    {
        Console.WriteLine($"Öğretmenin adı {name}, soyadı {lastname} ve doğum tarihi {birthDate}");
        Console.WriteLine("");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person student1 = new Person();
        student1.Name = "sinan";
        student1.LastName = "şenkul";
        student1.BirthDate = "04.09.1989";
        student1.LogInfoStudent();

        Person student2 = new Person();
        student2.Name = "alper";
        student2.LastName = "karalarlı";
        student2.BirthDate = "1997";
        student2.LogInfoStudent();

        Person teacher = new Person();
        teacher.Name = "sertan";
        teacher.LastName = "bozkuş";
        teacher.BirthDate = "1990";
        teacher.LogInfoTeacher();
    }
}
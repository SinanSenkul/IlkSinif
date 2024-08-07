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
    static void Main(string[] args)
    {
        Person student1 = new Person();
        student1.Name = "sinan";
        student1.LastName = "şenkul";
        student1.BirthDate = "04.09.1989";
        Console.WriteLine($"Öğrencinin adı {student1.Name}, soyadı {student1.LastName} ve doğum tarihi {student1.BirthDate}");

        Person student2 = new Person();
        student2.Name = "alper";
        student2.LastName = "karalarlı";
        student2.BirthDate = "1997";
        Console.WriteLine($"Öğrencinin adı {student2.Name}, soyadı {student2.LastName} ve doğum tarihi {student2.BirthDate}");

        Person teacher = new Person();
        teacher.Name = "sertan";
        teacher.LastName = "bozkuş";
        teacher.BirthDate = "1990";
        Console.WriteLine($"Öğretmenin adı {teacher.Name}, soyadı {teacher.LastName} ve doğum tarihi {teacher.BirthDate}");
    }
}
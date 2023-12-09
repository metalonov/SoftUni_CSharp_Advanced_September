
List<Student> students = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);

    Student student = new() { Name = name, Age = age };

    students.Add(student);
}

string filterType = Console.ReadLine();
int filterNumber = int.Parse(Console.ReadLine());

string format = Console.ReadLine();


class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
// 4th Day at BTK Akademi C# Programming Course
Student student1 = new();
student1.num = 10;
student1.name = "Kerim";

Student student2 = new();
student2.num = 5;
student2.name = "Semi";

Console.WriteLine($"Number of student 1: {student1.num} \nName of student 1: {student1.name}");
Console.WriteLine();
Console.WriteLine($"Number of student 2: {student2.num} \nName of student 2: {student2.name}");







class Student{
    public int num;
    public string name;
}

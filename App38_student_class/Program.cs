List<Student> student_list = new();

do{
    Console.Write("Enter the number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num == 0){
        break;
    }

    Console.Write("Enter the name: ");
    string name = Console.ReadLine();

    Console.Write("Enter the average grade: ");
    double average = Convert.ToDouble(Console.ReadLine());

    Student student1 = new();
    student1.num = num;
    student1.name = name;
    student1.average_grade = average;

    student_list.Add(student1);
} while(true);


foreach(Student s in student_list){
    Console.WriteLine($"Student number: {s.num} \nStudent name: {s.name} \nStudent grade average: {s.average_grade}");
}










class Student{
    public int num;
    public string name;
    public double average_grade;
}

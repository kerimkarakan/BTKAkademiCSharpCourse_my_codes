Dictionary<int, string> students = new (); // int = key, string = value oluyor burada

int num = 0;
string name = "";
do{
    Console.Write("Enter the student number that you want to add: ");
    num = Convert.ToInt32(Console.ReadLine());
    if(num != 0){
        if(students.ContainsKey(num)){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"A student already exists with the number {num}");
            Console.ForegroundColor = ConsoleColor.White;
            continue;
        }
        Console.Write("Enter the student name that you want to add: ");
        name = Console.ReadLine();

        students.Add(num, name);
    }


} while(num != 0);

Console.WriteLine("All Students");
foreach(var student in students){
    Console.WriteLine($"{student.Key} - {student.Value}");
}
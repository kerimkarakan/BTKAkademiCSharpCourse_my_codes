Console.Write("Enter first grade: ");
int grade1 = Convert.ToInt32(Console.ReadLine()); // bu notları double olarak alabilirsin direk kalvyeden 49,5 üzeri geçsin diye

Console.Write("Enter second grade: ");
int grade2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third grade: ");
int grade3 = Convert.ToInt32(Console.ReadLine());

double avg = (grade1 + grade2 + grade3) / 3.0; // 49,5 üzerindekiler geçsin diye bölüm sayısını double olarak yaptık (3.0 diye)
Console.WriteLine($"The average is {avg}");

if(avg >= 50){
    Console.WriteLine("Passed!");
}
else{
    Console.WriteLine("Failed!");
}

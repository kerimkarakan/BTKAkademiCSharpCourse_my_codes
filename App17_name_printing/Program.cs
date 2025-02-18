Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= age; i++){
    Console.WriteLine($"{i}. {name}");
}
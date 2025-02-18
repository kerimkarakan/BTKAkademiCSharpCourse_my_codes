
Console.Write("Enter a number: ");
int h = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < h; i++){
    for(int j = 0; j < i + 1; j++){
        Console.Write(" * ");
    }
    Console.WriteLine();
}

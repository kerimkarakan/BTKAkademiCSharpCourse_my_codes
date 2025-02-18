Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

if(num > 0){
    for(int i = num; i >= 1; i--){
    factorial *= i;
}
Console.WriteLine($"{num}! = {factorial}");
}
else if(num == 0){
    Console.WriteLine("0! = 1");
}
else{
    Console.WriteLine("The factorial of negative numbers cannot be calculated.");
}


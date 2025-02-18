Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"The bigger number is {num1}, smaller number is {num2}");
}
else if(num1 < num2){
    Console.WriteLine($"The bigger number is {num2}, smaller number is {num1}");
}
else{
    Console.WriteLine("The given numbers are equal to each other.");
}



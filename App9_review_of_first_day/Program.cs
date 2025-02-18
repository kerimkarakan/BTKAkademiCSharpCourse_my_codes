// 2nd Day at BTK Akademi C# Programming Course

using System.Transactions;

int num1 = 1; // değişken tanımlama
var a = 3.14; // bu şekilde tip belirlemene gerek yok program kendi belirliyor "var" kelimesiyle
string text = "35";

int num2 = Convert.ToInt32(text); // type converting 
byte b = (byte)num1; // type casting

Console.WriteLine(num1);
Console.Write(a);

Console.Write("How are you feeling today?");
string answer = Console.ReadLine();

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine()); // klavyeden input alma

Console.WriteLine($"You answer is {answer} \nThe entered number is {num}"); // yazıları birleştirme






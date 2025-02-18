// main program
using App42_class_methods;

FakeConsole con = new();

con.FakeClear(ConsoleColor.DarkRed);

int n1 = con.ReadNumber("Enter a number: ");
int n2 = con.ReadNumber("Enter another number: ");

con.Print($"Sum of the numbers {n1 + n2}");

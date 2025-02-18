int num = 0;
int sum = 0;

do
{
    Console.Write("Enter a number: ");
    num = Convert.ToInt32(Console.ReadLine());
    sum += num;

} while(num != 0);

Console.WriteLine("The sum of all the given numbers: "+ sum);

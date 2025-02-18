
int sum = 0;

for(int i = 1; i <= 5; i++){

    Console.Write($"Enter number {i}: ");
    int nums = Convert.ToInt32(Console.ReadLine());

    sum += nums;
}

double avg = sum / 5;

Console.WriteLine($"The average of the given numbers: {avg}");

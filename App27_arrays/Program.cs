int[] nums = [4, 8, 2, 3, -1];

Console.WriteLine("Number count in the array: "+nums.Length);

Console.WriteLine("The numbers in the array: ");

for(int i = 0; i < nums.Length; i++){
    Console.WriteLine($"{nums[i]} ");
}

int sum = 0;

foreach(int num in nums){ // int yerine var da yazabiliriz eğer arrayin içinde ne olduğunu bilmiyorsak
    sum += num;
}
Console.WriteLine($"The sum of the numbers in the array: {sum}");
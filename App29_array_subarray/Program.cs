int[] nums = [5, 1, 0, 9, 12, 4 ,8];

Console.WriteLine(nums[2]); // 0
Console.WriteLine(nums[^3]); // 12 
Console.WriteLine(nums[2..5]); // 0, 9 ,12 // 2. sıradan 5. sıraya kadar sayıları alıyor

var new_array = nums[2..5];
foreach(var n in new_array){
    Console.Write($"{n} ");
}

Console.WriteLine();
var new_array2 = nums[^6..];


foreach(var n in new_array2){
    Console.Write($"{n} ");
}

for(int i = 0; i < new_array2.Length; i++){
    var n = new_array2[i];
    Console.Write($"{n} ");
}


Console.WriteLine(nums[nums.Length-1]); // bunun aynısı nums[^1]



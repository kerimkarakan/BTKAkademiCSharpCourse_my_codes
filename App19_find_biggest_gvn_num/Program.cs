int smallest_num = int.MaxValue; // en küçük sayıya maksimum değer verdik
int biggest_num = int.MinValue; // en büyük sayıya minimum değer verdik
// bunlar en küçük ve en büyük sayıyı bulma algoritması

for(int i = 0; i < 5; i++){
    Console.Write($"Enter the number {i+1}: "); // 0 dan başladığımız için i+1 yazdık kullanıcıya düzgün görünmesi adına
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > biggest_num){
        biggest_num = num;
    }
    if(num < smallest_num){
        smallest_num = num;
    }
}

Console.WriteLine($"The biggest number: {biggest_num} \nThe smallest sumber is {smallest_num}");


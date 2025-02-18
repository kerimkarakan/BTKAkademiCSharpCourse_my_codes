int[] GenerateRandomNumber(){
    List<int> list = new();
    Random random = new Random();

    while(list.Count < 6){
        int num = random.Next(1, 49 + 1);
        if(!list.Contains(num)){ // eğer sayı listenin içinde yoksa ekliyecek varsa eklemeyecek bu sayede aynı sayıdan birden fazla tutmayacak
            list.Add(num);
        }
       
    }

    return list.ToArray(); // listeyi diziye dönüştür (liste olarak da döndürebiliyoruz böyle olmak zorunda değil)
}

void Print(int[] list){
    foreach(int n in list){
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}


// ana programın çalıştığı yer burası
var nums = GenerateRandomNumber();
Print(nums);


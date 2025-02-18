double CalculateTotal(double price, double amount = 1, double discount = 0){ //burada default değerler atadık parametrelere eğer hiç bir şey girilmezse
    double calculated_total = price * amount;
    if(discount > 0){
        calculated_total = calculated_total - calculated_total * (discount / 100);
    }
    return calculated_total;
}

void PrintPrint(params string[] list){ // bu şekilde istediğimiz kadar değişken alabiliyoruz ve bu method alt alta yazdırıyor verilen değişkenleri
    foreach(string str in list){
        Console.WriteLine(str);
    }
}

Console.WriteLine($"Calculated total: {CalculateTotal(16)}");
Console.WriteLine($"Calculated total: {CalculateTotal(16, 10)}");
Console.WriteLine($"Calculated total: {CalculateTotal(16, 10, 20)}");

PrintPrint("İzmir", "Ankara", "İstanbul", "Gaziantep", "Manisa");
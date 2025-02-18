int Sum(int a, int b){ // bunları metot olarak değilde fonksiyon olarak düşünebilirsin javadaki gibi sadece başında public yok
    int result = a + b;
    return result;
}

// bunlar resmen javadaki fonksiyonlar konusu

void ClearScreen(){
    Console.Clear();
}

void Wait(){
    Console.Write("Press a button to quit... ");
    Console.ReadKey();
}

int sumValue = Sum(6, 5);

int sum2 = Sum(-5, 9);
ClearScreen();

Console.WriteLine($"Sum of the first values: {sumValue}");
Console.WriteLine($"Sum of the second values: {sum2}");

Wait();

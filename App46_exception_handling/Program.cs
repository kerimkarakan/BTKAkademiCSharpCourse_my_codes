// 5th Day at BTK Akademi C# Programming Course

int ReadInt(string message){
    bool errorExists = false;
    int n = 0;
    do{
        errorExists = false;
        try{
             Console.Write(message);
             n = Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception error){
             Console.WriteLine("Error!");
             Console.WriteLine(error.Message); // hata ne olursa olsun böylece mesajını alabiliyoruz
             errorExists = true;
        }
        finally{ // finally ne olursa olsun her zaman çalışır (javada olduğu gibi aynısı)

        }
    }while(errorExists);
    return n;
}

Console.WriteLine("Calculator");


int n1 = 0, n2 = 0;
n1 = ReadInt("Enter first number: ");
n2 = ReadInt("Enter second number: ");

int sum = n1 + n2;

Console.WriteLine("Sum of the numbers: "+sum);

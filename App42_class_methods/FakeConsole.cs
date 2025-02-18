namespace App42_class_methods;

public class FakeConsole{
    public static void FakeClear(){ // eğer bütün hepsini static olarak yaparsak main programda hiç obje oluşturmadan direk bir şekilde kullanabiliriz: FakeConsole.FakeClear()
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }

    public void FakeClear(ConsoleColor color){
        Console.BackgroundColor = color;
        Console.Clear();
    }

    public void Print(string text){
        Console.WriteLine(text);
    }

    public string ReadText(){
        return Console.ReadLine();
    }

    public int ReadNumber(){
        return Convert.ToInt32(Console.ReadLine());
    }

    public int ReadNumber(string message){ // aşırı yüklenmiş oldu çünkü 1 tane parametresiz 1 tane parametreli var bu metottan
        Print(message);
        return Convert.ToInt32(Console.ReadLine());
    }



}

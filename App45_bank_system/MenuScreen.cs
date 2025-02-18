namespace App45_bank_system;

public class MenuScreen{
    public static int Show(){
        Console.Clear();
        Console.WriteLine("Welcome to Dotnet Bank\n\n");


        Console.WriteLine("1 - Add customer");
        Console.WriteLine("2 - Show customers");
        Console.WriteLine("3 - Open bank account");
        Console.WriteLine("4 - Deposit money");
        Console.WriteLine("5 - Withdraw money");
        Console.WriteLine("6 - Havale");
        Console.WriteLine("0 - Quit");
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
namespace App45_bank_system;

public class Account{ // C# da javadaki gibi class adı dosya adıyla aynı olmak zorunda değil dosya adını yanlış yazmışım
    public static long AccountNo {get; set;}
    public static string AccountType {get; set;}
    public static double Balance {get; set;}

    public static void OpenBankAccount(string accountType){
        accountType = AccountType;
        AccountNo = DateTime.Now.Ticks;
        Console.WriteLine($"Account successfully created. Account no is {AccountNo}. Press a button to continue.");
        Console.ReadKey();
    }

    public static void DepositMoney(int amount){
        Balance += amount;
    }
    public static void WithdrawMoney(int amount){
        if(Balance < amount){
            Console.WriteLine("The withdrawal amount exceeds the balance. Please deposit money.");
        }
        else{
            Balance -=amount;
        }
    }
    public static void Print(){
        Console.WriteLine($"Account no: {AccountNo} \nAccount type: {AccountType} \nBalance: {Balance}");
    }
}

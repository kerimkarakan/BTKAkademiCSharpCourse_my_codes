using App45_bank_system;
// bu uygulamayı sonradan müşteri bilgilerini tutması için json ile güncelledik ve o verileri bir dosyaya kaydettik 
// basit bir veri tabanı yapmış olduk

int choice = 0;
List<Customer> customerList = new();

customerList = FileOperations.OpenFile("customers.txt");

do{
    choice = MenuScreen.Show();

    if(choice == 1){
        AddingCustomer.Show(customerList);
    }
    else if(choice == 2){
        ShowCustomerScreen.Show(customerList);
    }
    else if(choice == 3){ // ben ekledim
        Console.Clear();
        Console.Write("Enter the account type for the account: ");
        string accountType = Console.ReadLine();
        Account.OpenBankAccount(accountType);
    }
    else if(choice == 4){ // ben ekledim
        Console.Write("Enter an amount to deposit: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        Account.DepositMoney(amount);
    }
    else if(choice == 5){ // ben ekledim
        Console.Write("Enter an amount to withdraw: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        Account.WithdrawMoney(amount);
    }
    else if(choice == 6){ // ben ekledim

    }
    else if(choice == 0){
        Console.WriteLine("Quitted.");
    }
    else{
        Console.WriteLine("Invalid input!");
        Console.ReadKey();
    }
} while(choice != 0);

FileOperations.Save(customerList, "customers.txt");

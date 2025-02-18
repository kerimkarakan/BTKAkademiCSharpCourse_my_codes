namespace App45_bank_system;

public class Customer{
    public long CustomerNo {get; set;}
    public string NameSurname {get; set;}

    public void Print(){
        Console.WriteLine($"Customer no: {CustomerNo} \nCustomer name and surname: {NameSurname}");
    }
}

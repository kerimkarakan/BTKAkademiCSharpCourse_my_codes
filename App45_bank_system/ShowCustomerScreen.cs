namespace App45_bank_system;

public class ShowCustomerScreen{
    public static void Show(List<Customer> list){
        Console.Clear();
        Console.WriteLine("Customer List");

        foreach(Customer c in list){
            c.Print();
        }
        Console.WriteLine("Customers listed. Press a button to continue... ");
        Console.ReadKey();
    }
}

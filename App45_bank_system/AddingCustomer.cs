namespace App45_bank_system;

public class AddingCustomer{
    public static void Show(List<Customer> customer_list){
        Console.Clear();
        Console.Write("Enter the name of the customer you want to add: ");
        string NameSurname = Console.ReadLine();

        Customer customer1 = new();
        customer1.NameSurname = NameSurname;
        customer1.CustomerNo = DateTime.Now.Ticks; // o anki zaman

        customer_list.Add(customer1);

        Console.WriteLine("Customer added. Press a button to continue... ");
        Console.ReadKey(); // bir tuşa basılana kadar bekliyor burada
    }
}

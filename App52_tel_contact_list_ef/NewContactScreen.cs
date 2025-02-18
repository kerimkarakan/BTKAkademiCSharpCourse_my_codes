namespace App52_tel_contact_list_ef;

public class NewContactScreen{
    public static void Show(DataBase connection){
        Console.WriteLine("Add New Contact Screen");
        Person person1 = new ();

        Console.Write("Please enter the name: ");
        person1.Name = Console.ReadLine();

        Console.Write("Please enter the surname: ");
        person1.Surname = Console.ReadLine();

        Console.Write("Please enter the tel no: ");
        person1.TelNo = Console.ReadLine();

        Console.Write("Please enter the address: ");
        person1.Address = Console.ReadLine();


        connection.People.Add(person1); // person 1 veri tabanına gönderildi
        connection.SaveChanges(); // değişiklikler kaydedildi
        Console.WriteLine("The person info is successfully saved.");
        Console.WriteLine("Press a button to continue.");
        Console.ReadKey();
    }
}


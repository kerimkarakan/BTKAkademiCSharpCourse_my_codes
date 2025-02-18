namespace App52_tel_contact_list_ef;

public class UpdateScreen{
    public static void Show(DataBase connection){
        Console.WriteLine("Update Screen");

        Console.Write("Enter the ID of the person you want to update: ");
        int Id = Convert.ToInt32(Console.ReadLine());

        Person person1 = connection.People.Find(Id); // ID'sini verdiğimiz kişiyi güncelliyor

        if(person1 == null){
            Console.WriteLine("The person is not found. \nPress a button to continue.");
            Console.ReadKey();
            return;
        }

        Console.Write("Please enter the name: ");
        person1.Name = Console.ReadLine();

        Console.Write("Please enter the surname: ");
        person1.Surname = Console.ReadLine();

        Console.Write("Please enter the tel no: ");
        person1.TelNo = Console.ReadLine();

        Console.Write("Please enter the address: ");
        person1.Address = Console.ReadLine();

        connection.SaveChanges();

        Console.WriteLine("The person info is successfully updated.");
        Console.WriteLine("Press a button to continue.");
        Console.ReadKey();
    }
}

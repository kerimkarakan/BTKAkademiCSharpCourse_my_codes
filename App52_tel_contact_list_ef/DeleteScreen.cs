namespace App52_tel_contact_list_ef;

public class DeleteScreen{
    public static void Show(DataBase connection){
        Console.WriteLine("Delete Contact Screen");

        Console.Write("Enter the ID of the persın you want to delete: ");
        int Id = Convert.ToInt32(Console.ReadLine());
        Person person1 = connection.People.Find(Id);

        if(person1 == null){
            Console.WriteLine("The person is not found.");
            Console.ReadKey();
            return;
        }

        connection.People.Remove(person1); // sildik o kişiyi veri tabanından
        connection.SaveChanges();

        Console.WriteLine("The person is successfully deleted.");
        Console.WriteLine("Press a button to continue.");
        Console.ReadKey();
    }
}

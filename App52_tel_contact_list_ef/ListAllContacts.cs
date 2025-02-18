namespace App52_tel_contact_list_ef;

public class ListAllContacts{
    public static void Show(DataBase connectiom){
        Console.Clear();
        Console.WriteLine("Contact List Screen");

        List<Person> list = connectiom.People.ToList(); // veri tabanındaki kişileri lis tolarak çektik böyle

        if(list.Count < 0){ // burada eğer listelenecek kimse yoksa listelemesin bu mesajı version istedim ama çalışmıyor
            Console.WriteLine("There is no person to list.");
            Console.WriteLine("Press a button to continue.");
            Console.ReadKey();
        }

        foreach(Person person in list){
            Console.WriteLine($"Person {person.Id}: {person.Name} - {person.Surname} - {person.TelNo} - {person.Address}");
        }

        Console.WriteLine("All contacts are successfully listed.");
        Console.WriteLine("Press a button to continue.");
        Console.ReadKey();

    }
}

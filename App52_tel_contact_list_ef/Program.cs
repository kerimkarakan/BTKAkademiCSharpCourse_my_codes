// Last day at BTK Akademi C# Programming Course
// EF (Entity Framework) ile veri tabanı işlmeleri
using App52_tel_contact_list_ef;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Contact list App\n----------------");

DataBase connection = new();

if(connection.Database.GetPendingMigrations().Count() > 0){
    connection.Database.Migrate(); // veri tabanını günceller

    Console.WriteLine("Data base is created and updated.");
}

//CRUD: Create, Read, Update, Delete
do{
    Console.Clear();
    Console.WriteLine("0 - Quit");
    Console.WriteLine("1 - Add new contact");
    Console.WriteLine("2 - List all contacts");
    Console.WriteLine("3 - Update");
    Console.WriteLine("4 - Delete");
    Console.WriteLine("5 - Delete All Contacts");
    Console.Write("Please enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 0){
        Console.WriteLine("Quitted.");
        return;
    }
    else if(choice == 1){
        NewContactScreen.Show(connection);
    }
    else if(choice == 2){
        ListAllContacts.Show(connection);
    }
    else if(choice == 3){
        UpdateScreen.Show(connection);
    }
    else if(choice == 4){
        DeleteScreen.Show(connection);
    }
    else if(choice == 5){
        // tüm kayıtları silme
        List<Person> list = connection.People.ToList();
        connection.People.RemoveRange(list);
        connection.SaveChanges();

        Console.WriteLine("All contacts are successfully deleted.");
        Console.WriteLine("Press a button to continue.");
        Console.ReadKey();
    }
    else{
        Console.WriteLine("Invalid choice!");
        Console.WriteLine("Press a vutton to continue.");
        Console.ReadKey();
    }

} while(true);

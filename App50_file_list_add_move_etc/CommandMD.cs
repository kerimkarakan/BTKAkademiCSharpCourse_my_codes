namespace App50_file_list_add_move_etc;

public class CommandMD{
    public static void AddFolder(){
        Console.Write("Enter the name of the folder you want to create: ");
        string folderPath = "/Users/kerimkarakan/" + Console.ReadLine();

        if(Directory.Exists(folderPath)){
            Console.WriteLine("The folder already exists.");
            return;
        }

        Directory.CreateDirectory(folderPath);
        Console.WriteLine("Folder is successfully created.");
    }
}

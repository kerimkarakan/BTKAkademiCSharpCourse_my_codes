namespace App50_file_list_add_move_etc;

public class CommandLs{
    public static void MakeItWork(string path, string[] args){
        string[] folders = Directory.GetDirectories(path);
        string[] files = Directory.GetFiles(path);

        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach(string folder in folders){
            Console.WriteLine(Path.GetFileName(folder));
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        foreach(string file in files){
            Console.WriteLine(Path.GetFileName(file));
        }

    }
}

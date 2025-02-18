namespace App50_file_list_add_move_etc;

public class CommandCd{
    public static void MakeItWork(string path, string[] args){
        if(args.Length < 2){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number of command parameters.");
            return;
        }

        string target = args[1]; // hedef klasör ya da .. (iki nokta yan yana)
        string targetPath = "";
        if(target == ".."){ // bir üst klasör
            targetPath = Path.GetDirectoryName(path);
        }
        else{
            string[] subFolders =  Directory.GetDirectories(path);
            foreach(string folder in subFolders){
                if(Path.GetFileName(folder) == target){
                    targetPath = folder;
                    break;
                }
            }
        }
        if(!string.IsNullOrEmpty(targetPath)){
            Directory.SetCurrentDirectory(targetPath);
        }
        else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The folder or file is not found.");
            return;
        }
    }
}

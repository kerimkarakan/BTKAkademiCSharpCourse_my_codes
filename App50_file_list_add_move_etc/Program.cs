using App50_file_list_add_move_etc;

string filePath;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    filePath = Directory.GetCurrentDirectory();
    Console.Write($"{filePath}>");
    string command = Console.ReadLine(); //cp yol1 yol2 diye alıcaz veriyi
    string[] commandArgs = command.Split(" ");

    switch(commandArgs[0]){
        case "help":
        CommandHelp.MakeItWork();
        break;

        case "ls":
        CommandLs.MakeItWork(filePath, commandArgs); // çok doğru çalışmıyor sanki
        break;

        case "cd":
        CommandCd.MakeItWork(filePath, commandArgs);
        break;

        case "clear": // ben yazdım
        CommandClear.Clear();
        break;

        case "md": // ben yazdım
        CommandMD.AddFolder();
        break;

        case "exit":
        return; // return yazarak şu an bulunduğumuz ana metodu sonlandırıyoruz aynı javada olduğu gibi

        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The command is not found.");
        break;
    }

} while(true);

// ekranı temizleme komutu eklenebilir (clear)
// md komutu eklenebilir: verilen klasörü oluşturacak
// newFile komutu: newFile dosyaadi.uzantı verdiğimizde o dosyayı oluşturacak

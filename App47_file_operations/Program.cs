using System.IO;

string path = "/Users/kerimkarakan/BtkAkdemiOcak2025"; // benim ana klasöre bu şekilde verdiğim isimle bir dosya oluşturdu
Directory.CreateDirectory(path);
Console.WriteLine($"The {path} is successfully created.");

path = "/Users/kerimkarakan";

if(Directory.Exists(path)){
    Console.WriteLine("The folder already exists.");

    string[] subFolders = Directory.GetDirectories(path);
    Console.WriteLine($"Folderc count: {subFolders.Length}");
    Console.ForegroundColor = ConsoleColor.Yellow;

    foreach(string folder in subFolders){
        Console.WriteLine(folder);
    }

    Console.ResetColor();

    string[] files = Directory.GetFiles(path);
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine($"File count: {files.Length}");
    foreach(string file in files){
        Console.WriteLine(file);
    }

    Console.ResetColor();

    // string homePath = Environment.GetEnvironmentVariable("HOME");
    // string desktopPath = Path.Combine(homePath, "Desktop");

    // Console.WriteLine($"Desktop: {desktopPath}"); // bu kodlar mac için çalışıyor copilottan aldım

    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // bu mac için çalışmıyor desktop path ini vermesi lazım ama vermiyor

    Console.WriteLine($"Desktop: {desktop}");
}

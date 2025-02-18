using System.IO;

string folderPath = "/Users/kerimkarakan/BtkAkdemiOcak2025";

if(!Directory.Exists(folderPath)){
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Folder is created.");
}

string filePath = folderPath + "/merhaba.txt";
string content = "Hello, C#.";

File.WriteAllText(filePath, content); // burası dosyayı açıyor, içeriği yazar, dosyayı kapatır otomatikmen
Console.WriteLine("File is created.");

string readingFile = File.ReadAllText(filePath); // burası dosyayı açar, veriyi okur, dosyayı kapatır
Console.WriteLine($"Content of the file: {readingFile}");

content = "\nIt is friday.";
File.AppendAllText(filePath, content); // böyle dosyaya sonradan bir şey ekleyebiliyoruz

readingFile = File.ReadAllText(filePath);
Console.WriteLine($"Content of the file (again): {readingFile}");
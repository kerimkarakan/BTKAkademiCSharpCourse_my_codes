using System.Globalization;
using System.IO;

string filePath = "/Users/kerimkarakan/BtkAkdemiOcak2025/numbers.txt";

if(File.Exists(filePath)){
    string content = File.ReadAllText(filePath);
    string[] numbersStr = content.Split(','); // virgülle ayrılıyor elemanlar böylece ve bir string arrayde topladık onları

    int sum = 0;
    foreach(string str in numbersStr){
        int number = Convert.ToInt32(str);
        sum += number;
    }

    Console.WriteLine($"Numbers: {content}");
    Console.WriteLine($"The sum of the numbers in the file: {sum}");
}
else{
    Console.WriteLine("The file is not found.");
}


namespace App45_bank_system;

using System.Text.Json;

public class FileOperations{
    public static void Save(List<Customer> list, string file){
        string jsonText = JsonSerializer.Serialize(list);
        
        File.WriteAllText(file, jsonText);
    }

    public static List<Customer> OpenFile(string file){
        if(!File.Exists(file)){
            return new List<Customer>();
        }
        string ReadFromFile = File.ReadAllText(file);

        List<Customer> list = JsonSerializer.Deserialize<List<Customer>>(ReadFromFile);

        return list;
    }
}

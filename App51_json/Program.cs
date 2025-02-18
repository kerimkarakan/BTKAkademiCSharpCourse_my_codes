Console.WriteLine("JSON operations");

Person person1 = new() {Id = 1, Name = "Ali", Surname = "Can", TelNo = "05467843920"};

string jsonText = System.Text.Json.JsonSerializer.Serialize(person1); // serileştirme
Console.WriteLine("Serialization: "+jsonText);

Person person2 = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonText); // geri serileştirme
Console.WriteLine($"Deseralization: {person2.Id} - {person2.Name} - {person2.Surname} - {person2.TelNo}");


class Person{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public string TelNo {get; set;}
}
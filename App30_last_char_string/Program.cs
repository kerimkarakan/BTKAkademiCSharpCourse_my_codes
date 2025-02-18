string text = "C# programming with BTK Akademi";

// string = Karakter Dizisi
// string özelleştirilmiş bir dizidir

Console.WriteLine(text[0]); // ilk karakter
Console.WriteLine(text[^1]); // son karakter
Console.WriteLine(text[4..11]);

foreach(var ch in text){
    Console.Write($"{ch} ");
}
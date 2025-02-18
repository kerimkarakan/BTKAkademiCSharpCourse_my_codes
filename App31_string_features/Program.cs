Console.Write("Enter a text: ");
string txt = Console.ReadLine();

Console.WriteLine("Text length: "+ txt.Length);
Console.WriteLine(txt.ToUpper());
Console.WriteLine("Does the text end with a dot? "+txt.EndsWith("."));

var words = txt.Split(" ");

Console.WriteLine($"The first word: {words[0]}");
Console.WriteLine($"Last word: {words[^1]}");
Console.WriteLine($"Total word count: {words.Length}");

txt = txt.Replace(words[0], "*******");

Console.WriteLine($"New text: {txt}");




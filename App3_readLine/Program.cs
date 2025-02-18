// klavyeden okuma (input alma)

Console.ForegroundColor = ConsoleColor.Black; // yazıların rengini değiştiriyor
Console.BackgroundColor = ConsoleColor.White; // arka planın rengini değiştiriyor
Console.Clear(); // her şeyi temizliyor kodu çalıştırırken (bunlar çok önemli değil kodlama adına)

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.Write("Hello, ");
Console.WriteLine(name);

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine()); // string tipini int ye çevirdik çünkü klavyeden int alıcaz (javadaki gibi okurken int al falan diyemiyorsun burada galiba)

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()); // yine yukarıdaki aynı işlemi farklı bir şekilde yaptık

Console.WriteLine(num1 + num2);



// yine javada olduğu gibi "+" işareti ile stingleri birbirine ekleyebiliriz (ya da sayıları toplarız)

int a = 5, b= 3;

int result = a * b;

Console.WriteLine(a + " * " + b + " = " + result);
Console.WriteLine(string.Format("{0} * {1} = {2}", a, b, result)); // bu da başka bir yöntem
Console.WriteLine("{0} * {1} = {2}", a, b, result); // yine başka bir yöntem
Console.WriteLine($"{a} * {b} = {result}"); // yine ayrı bir yöntem ve bu en basit yöntem şu anda (string interpolation adı)

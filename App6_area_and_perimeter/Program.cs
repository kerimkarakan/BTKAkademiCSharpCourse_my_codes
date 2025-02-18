Console.Write("Enter the a side of the rectangele: ");
int side_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the b side of the rectangle: ");
int side_b = Convert.ToInt32(Console.ReadLine());

var area = side_a * side_b;
var perimeter = (side_a + side_b) * 2;

Console.WriteLine($"The area of the rectangle which has the sides \"{side_a}\" and \"{side_b}\" is {area}."); // yine javadaki gibi kaçıs karakterleri mevcut C# da
Console.WriteLine($"The perimeter of the rectangle which has the sides {side_a} and {side_b} is {perimeter}.");



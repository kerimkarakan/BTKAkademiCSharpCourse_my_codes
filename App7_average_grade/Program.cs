Console.Write("Enter the first grade: ");
double grade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second grade: ");
double grade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third grade: ");
double grade3 = Convert.ToDouble(Console.ReadLine());

double avg = (grade1 + grade2 + grade3) / 3;

Console.WriteLine($"{"Grade1", -11}| {"Grade2", -10} | {"Grade3", -10} | {"Average", 15}"); // hizalama yapıyoruz bu şekilde (sayılar boşluk sayısını temsil ediyor (eğer - ise sola doğru, + ise sağa doğru boşluk))
Console.WriteLine($"{grade1, -10:f2} | {grade2, -10:f2} | {grade3, -10:f2} | {avg, 15:f2}"); // f2 virgülden sonra sadece 2 basamak gelsin demek

// aritmetiksel operatörler

int a = 2, b= 3, c= 6;
Console.WriteLine($"a = {a}, b = {b}, c = {c}");

a += 3; // a ya 3 ekle
b--; // b yi 1 azalt
c = a++ + b; // a ile b yi topla bu c olsun sonrasında a yı 1 artır

Console.WriteLine($"a = {a}, b = {b}, c = {c}");

a = a & b; // bitsel and operatörü> 0110 & 0010 == 0010

Console.WriteLine($"a = {a}, b = {b}, c = {c}");

// Variables
int sayi = 35; // tam sayı değişkeni tanımalma
string metin = "İzmir"; // string değişkeni tanımlama
double o_sayi = 13.2; // ondalıklı sayı tanımlama
Console.WriteLine(sayi);
Console.WriteLine(metin);
Console.WriteLine(o_sayi);

int a, b, c; // bu şekilde çoklu değişken tanımlayabiliriz
a = 1;
b = 2;
c = 3;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

/* variable types
1- byte
2- sbyte
3- int
4- uint
5- short
6- ushort
7- long
8- ulong
9- float
10- double
11-decimal
12- bool
13- char */

// Değişken isimleri sayı ile başlayamaz.
// Zorunlu olmasa da türkçe karaktlerler kullanılmamalıdır.
// C# küçük/büyük harf duyarlıdır. Console ile console aynı şey değil mesela. (aynı Java gibi)

// Değişken isimlendirme yöntemleri = camelCase, PascalCase, xMacarNotasyonu

int sayi2; // varsayılan değer 0 burada
int? sayi3 = null; // burada varsayılan değer 0 değir, null olur. Eğer soru işaretini koymazsak burada, null değerini koyamayız.

var sayi4 = 5; // bu şekilde tip belirlemene gerek yok burada kendi belirliyor tipini otomatikmen senin ne verdiğine göre.

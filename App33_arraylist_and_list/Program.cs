using System.Collections;

ArrayList arrayList = ["İzmir", 35, 3.14, true]; // ArrayList içine farklı tür elemanlar koyulabiliyor
arrayList.Add("Btk");
arrayList.Insert(2, -1);
foreach(var i in arrayList){
    Console.Write($"{i} ");
}
Console.WriteLine();

List<int> list = [5, 6, 2, 9, 7, 7]; // list içerisine tek bir tür veri saklanabiliyor ve normal arraylerden farkı sonradan içine bir şey eklenip çıkarılabilmesi

list.RemoveAt(list.Count - 1); // belirli bir yerdeki veriyi sil
list.Add(3);
list.AddRange([1, 8, 4]);
list.Insert(0, 11); // 0. yere 11 sayısını ekle

foreach(var i in list){
    Console.WriteLine($"{i} ");
}
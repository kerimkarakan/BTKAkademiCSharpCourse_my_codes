Book[] books = [new(){Name = "C#", Price = 199, PageNum = 250 }, 
new(){ Name = "Python", Price = 179, PageNum = 300 }, 
new(){ Name = "Introduction to AI", Price = 259, PageNum= 350 }];

foreach(Book b in books){
    Console.WriteLine($"Name of the book: {b.Name} \nPrice of the book: {b.Price:c2} \nPage number of the book: {b.PageNum}"); // c2 koyarsak para birimi olarak gösterir
}


class Book{

    private int page;
    // properties büyük harfle başlar
    public string Name {get; set;}
    public double Price {get; set;}
    public int PageNum {
        get => page; 
        set => page = (value < 0)? 0 : value;
    } // en sonda eğer sayfa sayısı negatif olarak girilirse 0 a eşitleyecek eğer değilse normal girilen değeri alacak 

}

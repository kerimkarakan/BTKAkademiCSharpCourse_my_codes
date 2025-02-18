// alınan bir stringi tersten yazdırma
Stack<char> stack = new ();

Console.Write("Enter a text: ");
string txt = Console.ReadLine();

foreach(var ch in txt){
    stack.Push(ch);
}

while(stack.Count > 0){
    char item = stack.Pop();
    Console.Write($"{item}");
}

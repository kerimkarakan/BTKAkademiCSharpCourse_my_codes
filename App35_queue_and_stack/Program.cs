Queue<int> queue = new ();

queue.Enqueue(4); //ekleme
queue.Enqueue(3);
queue.Enqueue(6);
queue.Enqueue(9);

Console.WriteLine($"Queue items ({queue.Count})");
while(queue.Count > 0){
    int item = queue.Dequeue(); // queue den çıkar
    Console.Write($"{item} ");
}


Stack<int> stack = new ();

stack.Push(4);
stack.Push(3);
stack.Push(6);
stack.Push(9);

Console.WriteLine($"\nStack items ({stack.Count})");
while(stack.Count > 0){
    int item = stack.Pop();
    Console.Write($"{item} ");
}


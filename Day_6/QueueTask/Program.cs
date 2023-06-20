
Queue<string> queue = new Queue<string>();
queue.Enqueue("Apple");
queue.Enqueue("Banana");
queue.Enqueue("Cherries");
queue.Enqueue("Orange");
queue.Enqueue("Pear");
foreach (string fruit in queue)
{
    Console.WriteLine(fruit);
}
Console.WriteLine("First element is: " + queue.Peek());
queue.Dequeue();
queue.Dequeue();
Console.WriteLine("Queue after removal:");
foreach (string fruit in queue)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("First element after removal is: " + queue.Peek());


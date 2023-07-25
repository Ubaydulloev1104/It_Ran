using System.Collections.Generic;
Stack<string> myStack = new Stack<string>();
myStack.Push("Apple");
myStack.Push("Banana");
myStack.Push("Cherries");
myStack.Push("Orange");
myStack.Push("Pear");
foreach (string item in myStack)
{
    Console.WriteLine(item);
}
Console.WriteLine("First item: " + myStack.Peek());
myStack.Pop();
myStack.Pop();
foreach (string item in myStack)
{
    Console.WriteLine(item);
}

Console.WriteLine("First item: " + myStack.Peek());
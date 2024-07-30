using System;
using System.Collections;
class Program
{

    public class Queue
    {
        public Stack firstStack = new Stack();
        public Stack secondStack = new Stack();
        public void EnQueue(int x)
        {
            while (firstStack.Count > 0)
            {
                secondStack.Push(firstStack.Pop()); 
            }
            // Push item into firstStack  
            firstStack.Push(x);
            // Push everything back to firstStack  
            while (secondStack.Count > 0)
            {
                firstStack.Push(secondStack.Pop());
                //secondStack.Pop();  
            }
        }
        // Dequeue an item from the queue  
        public int DeQueue()
        {
            // if first stack is empty  
            if (firstStack.Count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            // Return top of firstStack  
            int DeQueuedElement = (int)firstStack.Peek();
            firstStack.Pop();
            return DeQueuedElement;
        }
    };
    public static void Main()
    {
        Queue q = new Queue();
        q.EnQueue(1);
        q.EnQueue(2);
        q.EnQueue(3);
        Console.WriteLine(q.DeQueue());
        Console.WriteLine(q.DeQueue());
        Console.WriteLine(q.DeQueue());
    }
}
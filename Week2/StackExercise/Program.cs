using System;
using StackExercise.Queues;
using StackExercise.Stacks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== ArrayStack Test ==========");
            ArrayStack<int> ast = new ArrayStack<int>(10);

            Console.WriteLine("Adds 1 to stack");
            ast.push(1);
            Console.WriteLine("Peek stack: " + ast.peek());
            Console.WriteLine("Pop stack: " + ast.pop());
            Console.WriteLine("Adds 2 to stack");
            Console.WriteLine("Adds 5 to stack");
            Console.WriteLine("Adds 9 to stack");
            ast.push(2);
            ast.push(5);
            ast.push(9);
            Console.WriteLine("Peek stack: " + ast.peek());
            Console.WriteLine("Pop stack: " + ast.pop());
            Console.WriteLine("Peek stack: " + ast.peek());


            Console.WriteLine("========== LinkedStack Test ==========");
            LinkedStack<int> lst = new LinkedStack<int>();

            Console.WriteLine("Adds 1 to stack");
            lst.push(1);
            Console.WriteLine("Peek stack: " + lst.peek());
            Console.WriteLine("Pop stack: " + lst.pop());
            Console.WriteLine("Adds 2 to stack");
            Console.WriteLine("Adds 5 to stack");
            Console.WriteLine("Adds 9 to stack");
            lst.push(2);
            lst.push(5);
            lst.push(9);
            Console.WriteLine("Peek stack: " + lst.peek());
            Console.WriteLine("Pop stack: " + lst.pop());
            Console.WriteLine("Peek stack: " + lst.peek());

            Console.WriteLine("========== LinkedQueue Test ==========");
            LinkedQueue<int> lqu = new LinkedQueue<int>();

            Console.WriteLine("Enqueues 1 to queue");
            lqu.enqueue(1);
            Console.WriteLine("Peek queue: " + lqu.peek());
            Console.WriteLine("Enqueues 2 to queue");
            lqu.enqueue(2);
            Console.WriteLine("Peek queue: " + lqu.peek());
            Console.WriteLine("Enqueues 6 to queue");
            lqu.enqueue(6);
            Console.WriteLine("Peek queue: " + lqu.peek());
            Console.WriteLine("Enqueues 9 to queue");
            lqu.enqueue(9);
            Console.WriteLine("Peek queue: " + lqu.peek());
            Console.WriteLine("Dequeues from queue: " + lqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + lqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + lqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + lqu.dequeue());

            Console.WriteLine("========== ArrayQueue Test ==========");
            ArrayQueue<int> aqu = new ArrayQueue<int>(10);

            Console.WriteLine("Enqueues 1 to queue");
            aqu.enqueue(1);
            Console.WriteLine("Peek queue: " + aqu.peek());
            Console.WriteLine("Enqueues 2 to queue");
            aqu.enqueue(2);
            Console.WriteLine("Peek queue: " + aqu.peek());
            Console.WriteLine("Enqueues 6 to queue");
            aqu.enqueue(6);
            Console.WriteLine("Peek queue: " + aqu.peek());
            Console.WriteLine("Enqueues 9 to queue");
            aqu.enqueue(9);
            Console.WriteLine("Peek queue: " + aqu.peek());
            Console.WriteLine("Dequeues from queue: " + aqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + aqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + aqu.dequeue());
            Console.WriteLine("Dequeues from queue: " + aqu.dequeue());
        }
    }
}

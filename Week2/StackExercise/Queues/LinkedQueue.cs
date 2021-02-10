using System;

namespace StackExercise.Queues
{
    public class LinkedQueue<T> : IQueue<T>
    {
        Node front;
        Node rear;

        private class Node {
            public T value;
            public Node next;
            
            public Node(T value) {
                this.value = value;
            }
        }

        public void enqueue(T item) {
            Node newNode = new Node(item);

            if(this.rear == null)
                front = rear = newNode;
            else {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public T dequeue() {
            if(this.front == null)
                throw new OverflowException();
                
            Node temp = this.front;
            this.front = this.front.next;

            if(this.front == null)
                this.rear = null;
            
            return temp.value;
        }

        public T peek() {
            if(this.front == null)
                throw new OverflowException();
                
            return front.value;
        }
    }
}
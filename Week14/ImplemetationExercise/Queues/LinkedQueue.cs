using System;

namespace ImplemetationExercise.Queues
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

        public void add(T item) {
            Node newNode = new Node(item);

            if(rear == null)
                front = rear = newNode;
            else {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public T pop() {
            isEmpty();
                
            Node temp = front;
            front = front.next;

            if(front == null)
                rear = null;
            
            return temp.value;
        }

        public T peek() {
            isEmpty();                
            return front.value;
        }

        private void isEmpty() {
            if(front == null)
                throw new OverflowException();
        }
    }
}
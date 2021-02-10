using System;

namespace StackExercise.Stacks
{
    public class LinkedStack<T> : IStack<T>
    {
        Node top;

        private class Node {
            public T value;
            public Node next;
            
            public Node(T value, Node next) {
                this.value = value;
                this.next = next;
            }
        }

        public void push(T item) {
            top = new Node(item, top);
        }

        public T pop() {
            if(top == null)
                throw new OverflowException();
                
            T val = top.value;
            top = top.next;
            return val;
        }

        public T peek() {
            if(top == null)
                throw new OverflowException();
            return top.value;
        }

        
    }
}

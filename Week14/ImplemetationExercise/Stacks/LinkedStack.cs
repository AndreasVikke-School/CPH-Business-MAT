using System;

namespace ImplemetationExercise.Stacks
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

        public void add(T item) {
            top = new Node(item, top);
        }

        public T pop() {
            isEmpty();
            T val = top.value;
            top = top.next;
            return val;
        }

        public T peek() {
            isEmpty();
            return top.value;
        }

        private void isEmpty() {
            if(top == null)
                throw new OverflowException();
        }
    }
}

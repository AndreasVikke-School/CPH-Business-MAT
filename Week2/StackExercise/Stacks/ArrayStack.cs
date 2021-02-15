using System;

namespace StackExercise.Stacks
{
    public class ArrayStack<T> : IStack<T>
    {
        public T[] tarray;
        int size;
        int pointer;

        public ArrayStack(int size) {
            this.size = size;
            pointer = 0;
            tarray = new T[size];
        }

        public void push(T item) {
            if (pointer < size)
                tarray[pointer++] = item;
            else
                throw new OverflowException();
        }

        public T pop() {
            isEmpty();
            return tarray[--pointer];
        }

        public T peek() {
            isEmpty();
            return tarray[pointer - 1];
        }

        private void isEmpty() {
            if(pointer <= 0) 
                throw new OverflowException();
        }
    }
}

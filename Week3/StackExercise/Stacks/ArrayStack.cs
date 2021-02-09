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
        }

        public T pop() {
            if(pointer > 0) 
                return tarray[--pointer];
            throw new OverflowException();
        }

        public T peek() {
            if(pointer > 0)
                return tarray[pointer - 1];
            throw new OverflowException();
        }
    }
}

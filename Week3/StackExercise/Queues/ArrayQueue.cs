using System;

namespace StackExercise.Queues
{
    public class ArrayQueue<T> : IQueue<T>
    {
        public T[] tarray;
        int front;

        public ArrayQueue(int size) {
            tarray = new T[size];
            front = 0;
        }

        public void enqueue(T item) {
            tarray[front++] = item;
        }

        public T dequeue() {
            T temp = tarray[0];

            T[] newArray = new T[tarray.Length];
            Array.Copy(tarray, 1, newArray, 0, tarray.Length - 1);
            tarray = newArray;

            return temp;
        }

        public T peek() {
            return tarray[0];
        }
    }
}
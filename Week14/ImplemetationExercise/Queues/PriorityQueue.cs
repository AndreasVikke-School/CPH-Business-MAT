using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplemetationExercise.Queues
{
    public class PriorityQueue<T> : IQueue<T> where T : IComparable<T> {
        private List<T> data;

        public PriorityQueue() {
            data = new List<T>();
        }

        public void add(T item) {
            data.Add(item);
        }

        public T peek() {
            return data.Max();
        }

        public T pop() {
            T item = data.Max();
            data.Remove(item);
            return item;
        }
    }
}
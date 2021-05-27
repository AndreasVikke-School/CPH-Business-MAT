using System;

namespace ImplemetationExercise.Stacks
{
    public interface IStack<T>
    {
        void add(T item);
        T pop();
        T peek();
    }
}

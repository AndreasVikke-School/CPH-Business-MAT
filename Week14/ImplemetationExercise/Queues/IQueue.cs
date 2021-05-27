namespace ImplemetationExercise.Queues
{
    public interface IQueue<T>
    {
         void add(T item);
         T pop();
         T peek();
    }
}
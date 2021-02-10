namespace StackExercise.Queues
{
    public interface IQueue<T>
    {
         public void enqueue(T item);
         T dequeue();
         T peek();
    }
}
using System.Collections.Generic;

public class CircularBuffer<T>
{
    //Collection itself
    private List<T> buffer;
    //Capacity Variable
    private int capacity;

    //Contructor - Allows me to create a circular buffer with a capacity
    public CircularBuffer(int size)
    {
        buffer = new List<T>(size);
        this.capacity = size;
    }

    //Public Property
    //Read-Only Count property
    
    public int Count => buffer.Count;

    //Buffer Operations
    //=================
    //1.Push -- Adding new info to buffer
    public void Push(T item)
    {
        //Check if my buffer is at or above capacity
        if(buffer.Count >= capacity)
        {
            buffer.RemoveAt(0); //Removes the oldest Item
        }
        buffer.Add(item);  
    }
    //2.Pop -- Removing the next peice of info from the buffer
    public T Pop()
    {
        if (buffer.Count == 0)
        {
            return default(T); //Default returns the default value of the datatype T
        }

        int lastIndex = buffer.Count - 1;

        T item = buffer[lastIndex]; //Creates a copy of the item in Buffer[LastIndex] and stores it in 'Item'
        buffer.RemoveAt(lastIndex);   //Removes item from last Index

        return item;
    }
}

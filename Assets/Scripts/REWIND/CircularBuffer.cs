using System.Collections.Generic;

public class CircularBuffer
{
    //Collection itself
    private List<int> buffer;
    //Capacity Variable
    private int capacity;

    //Contructor - Allows me to create a circular buffer with a capacity
    public CircularBuffer(int size)
    {
        buffer = new List<int>(size);
        this.capacity = size;
    }

    //Public Property
    //Read-Only Count property
    //public int Count
    //{
    //    get
    //    {
    //        return buffer.Count;
    //    }
    //}
    public int Count => buffer.Count;

    //Buffer Operations
    //=================
    //1.Push -- Adding new info to buffer
    public void Push(int item)
    {
        //Check if my buffer is at or above capacity
        if(buffer.Count >= capacity)
        {
            buffer.RemoveAt(0); //Removes the oldest Item
        }
        buffer.Add(item);  
    }
    //2.Pop -- Removing the next peice of info from the buffer
    public int Pop()
    {
        if (buffer.Count == 0)
        {
            return -1; // -1 Will act as a special value to check against
        }

        int lastIndex = buffer.Count - 1;

        int item = buffer[lastIndex]; //Creates a copy of the item in Buffer[LastIndex] and stores it in 'Item'
        buffer.Remove(lastIndex);   //Removes item from last Index

        return item;
    }
}

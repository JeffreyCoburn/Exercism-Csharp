using System;

public class CircularBuffer<T>
{
    private T[] buffer;
    private int newest = 0;
    private int oldest = 0;
    private int count = 0;
    public CircularBuffer(int capacity)
    {
        buffer = new T[capacity];
    }

    public T Read()
    {
        if (count==0)
        {
            throw new InvalidOperationException("Can't read an empty buffer");
        }
        T value = buffer[oldest];
        oldest = (oldest+1) % buffer.Length;
        count--;
        return value;
    }

    public void Write(T value)
    {
        if (count == buffer.Length)
        {
            throw new InvalidOperationException("Must use overwrite to write to a full buffer");
        }
        buffer[newest]=value;
        newest = (newest+1) % buffer.Length;
        count++;       
    }

    public void Overwrite(T value)
    {
        // If buffer is full clear out oldest item
        if (count == buffer.Length)
        {
            oldest = (oldest+1) % buffer.Length;
            count--;
        }
        Write(value);
    }

    public void Clear()
    {
        if (count > 0)
        {
            Read();
        }
    }
}
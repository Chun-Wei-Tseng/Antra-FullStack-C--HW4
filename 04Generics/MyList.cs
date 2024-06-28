namespace _04Generics;

public class MyList<T>
{
    private List<T> list = new List<T>();
    
    public void Add(T element)
    {
        list.Add(element);
    }
    
    public T Remove(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        T item = list[index];
        list.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        list.Insert(index, element);
    }
    
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        list.RemoveAt(index);
    }
    
    public T Find(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        return list[index];
    }
}
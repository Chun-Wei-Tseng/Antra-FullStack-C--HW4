namespace _04Generics;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> context = new List<T>();
    public void Add(T item)
    {
        context.Add(item);
    }

    public void Remove(T item)
    {
        context.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved.");
    }

    public IEnumerable<T> GetAll()
    {
        return context;
    }

    public T GetById(int id)
    {
        return context.FirstOrDefault(e => e.Id == id);
    }
}
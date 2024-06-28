// See https://aka.ms/new-console-template for more information

using _04Generics;

var stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine("Stack count: " + stack.Count());
Console.WriteLine("Popped from stack: " + stack.Pop());
Console.WriteLine("Stack count after pop: " + stack.Count());

var list = new MyList<string>();
list.Add("Hello");
list.Add("World");
Console.WriteLine("List contains 'Hello': " + list.Contains("Hello"));
Console.WriteLine("Element at index 1: " + list.Find(1));
list.InsertAt("C#", 1);
Console.WriteLine("Element at index 1 after insertion: " + list.Find(1));
list.DeleteAt(1);
Console.WriteLine("Element at index 1 after deletion: " + list.Find(1));
list.Clear();
Console.WriteLine("List count after clearing: " + list.Contains("Hello"));

var repository = new GenericRepository<Entity>();
var entity1 = new Entity { Id = 1 };
var entity2 = new Entity { Id = 2 };
repository.Add(entity1);
repository.Add(entity2);
Console.WriteLine("Repository count: " + repository.GetAll().Count());
repository.Remove(entity1);
Console.WriteLine("Repository count after removal: " + repository.GetAll().Count());
repository.Save();
Console.WriteLine("Entity with Id 2: " + repository.GetById(2)?.Id);
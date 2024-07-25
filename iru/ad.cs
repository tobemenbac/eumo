public class MyClass
{
    private readonly Dictionary<string, string?> _query = new Dictionary<string, string?>()
    {
        {"key1", "value1"},
        {"key2", null}
    };

    public IReadOnlyDictionary<string, string?> Query => _query;
}

class Program
{
    static void Main()
    {
        var instance = new MyClass();
        
        // Accessing the Query property
        foreach (var kvp in instance.Query)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value ?? "null"}");
        }
    }
}

using DependencyInjectionNet8.Interfaces;

namespace DependencyInjectionNet8.Services;

public class ConsoleMessageWriter : IMessageWriter
{
    private readonly string id = Guid.NewGuid().ToString();

    public string Id => id;

    public bool WriteMessage(string message)
    {
        try
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(message);
            Console.WriteLine(message);
        }
        catch (Exception e)
        {
            return false;
        }
        return true;
    }
}
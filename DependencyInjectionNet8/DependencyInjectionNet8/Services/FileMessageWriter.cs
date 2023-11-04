using DependencyInjectionNet8.Interfaces;

namespace DependencyInjectionNet8.Services;

public class FileMessageWriter : IMessageWriter
{
    public bool WriteMessage(string message)
    {
        try
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(message);
            File.WriteAllText("Messages.txt",message);
        }
        catch (Exception e)
        {
            return false;
        }

        return true;
    }
}
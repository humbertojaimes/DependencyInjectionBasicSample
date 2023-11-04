using DependencyInjectionNet8.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionNet8;

public class MessageGenerator(IMessageWriter messageWriter)
{

    public void GenerateMessages()
    {
        for (int i = 0; i < 10; i++)
        {
            messageWriter?.WriteMessage(i.ToString());
        }
    }

}
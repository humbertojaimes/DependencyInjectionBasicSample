using System.Formats.Asn1;
using DependencyInjectionNet8;
using DependencyInjectionNet8.Interfaces;
using DependencyInjectionNet8.Services;
using Microsoft.Extensions.DependencyInjection;
using static System.Console;

WriteLine("Hello, World!");

IServiceProvider sp = ConfigureServices();

using (var scope = sp.CreateScope())
{
    IMessageWriter messageWriter1 = sp.GetRequiredService<IMessageWriter>();
    IMessageWriter messageWriter2 = sp.GetRequiredService<IMessageWriter>();
    messageWriter1?.WriteMessage("Hola");

    MessageGenerator messageGenerator = sp.GetRequiredService<MessageGenerator>() ;
    messageGenerator.GenerateMessages();
}



IServiceProvider ConfigureServices()
{
    ServiceCollection services = new();
    //services.AddScoped<IMessageWriter, FileMessageWriter>();
    services.AddScoped<IMessageWriter, ConsoleMessageWriter>();
    services.AddTransient<MessageGenerator>();
    return services.BuildServiceProvider();
}
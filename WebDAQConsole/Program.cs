
using WebDAQCore.Configuration;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;

namespace WebDAQConsole;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IConfiguration config = new CoreConfiguration().GetConfiguration();

        IConfiguration DatabaseConfig = config.GetSection("Database");
        Console.WriteLine(DatabaseConfig["Host"]);
    }
}

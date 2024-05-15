
using WebDAQCore.Configuration;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using WebDAQCore.Services;

namespace WebDAQConsole;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MessageQueueService messageQueueService = new MessageQueueService();
        Console.WriteLine(messageQueueService.Print());

    }
}

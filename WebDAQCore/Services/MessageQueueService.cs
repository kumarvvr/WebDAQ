namespace WebDAQCore.Services;

using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using WebDAQCore.Configuration;

public class MessageQueueService
{
    private readonly IConnection MessageQueueConnection;
    private readonly IModel channel;
    private readonly IConfiguration? configuration;
    public MessageQueueService()
    {
        this.configuration = ConfigManager.GetConfiguration();

        IConfiguration? MQConfig = this.configuration.GetSection("MessageQueue"); 

        ConnectionFactory factory = new ConnectionFactory();
        factory.HostName = MQConfig["Host"];
        factory.VirtualHost = MQConfig["VirtualHost"];
        factory.UserName = MQConfig["UserName"];
        factory.Password = MQConfig["Password"];
        factory.ClientProvidedName = MQConfig["ClientProvidedName"];

        this.MessageQueueConnection = factory.CreateConnection();

        this.channel = MessageQueueConnection.CreateModel();

    }

    public string Print()
    {
        return this.MessageQueueConnection.ToString();
    }

    public void CloseBus()
    {
        this.channel.Close();
        this.MessageQueueConnection.Close();
        this.MessageQueueConnection.Dispose();
    }


}

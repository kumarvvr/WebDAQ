namespace WebDAQCore.Services;
using RabbitMQ.Client;

public class MessageQueueService
{
    private readonly IConnection MessageQueueConnection;
    private readonly IModel channel;
    public MessageQueueService()
    {
        ConnectionFactory factory = new ConnectionFactory();
        factory.HostName = "localhost";
        factory.VirtualHost = "/";
        factory.UserName = "admin";
        factory.Password = "admin";
        factory.ClientProvidedName = "BHEL.WebDAQ";
        
        this.MessageQueueConnection = factory.CreateConnection();

        this.channel = MessageQueueConnection.CreateModel();

    }

    public void CloseBus()
    {
        this.channel.Close();
        this.MessageQueueConnection.Close();
        this.MessageQueueConnection.Dispose();
    }


}

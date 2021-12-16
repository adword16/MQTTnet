using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Packets;

public interface IUnSuccessfulSendHandler
{
    Task HandleUnSuccessfulSendMessage(MqttApplicationMessage package);
}
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Packets;

public interface ISuccessfulSendHandler
{
    Task HandleSuccessfulSendMessage(MqttApplicationMessage package);
}
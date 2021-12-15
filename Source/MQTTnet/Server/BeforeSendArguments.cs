using MQTTnet;

public class BeforeSendArguments
{
    public MqttApplicationMessage ApplicationMessage { get; set; }
    public bool DoSend { get; set; } = true;
}